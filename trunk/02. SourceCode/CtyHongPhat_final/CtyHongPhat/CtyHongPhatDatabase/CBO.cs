using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace CtyHongPhatDatabase
{
    /// <summary>
    /// Common Business Object
    /// </summary>
    public class CBO
    {
        /// <summary>
        /// Lấy tên các columns trong một table
        /// </summary>
        /// <param name="objIDataReader">Table cần lấy các columns</param>
        /// <returns>Danh sách tên các columns</returns>
        private static ArrayList TableColumns(IDataReader objIDataReader)
        {
            ArrayList objColumns = new ArrayList(objIDataReader.FieldCount);
            for (int i = 0; i < objIDataReader.FieldCount; i++)
                objColumns.Add(objIDataReader.GetName(i));
            return objColumns;
        }

        /// <summary>
        /// Lấy các properties của một đối tượng
        /// </summary>
        /// <param name="objType">Kiểu đối tượng</param>
        /// <returns>Danh sách các properties</returns>
        private static PropertyInfo[] ObjectProperties(Type objType)
        {
            return objType.GetProperties();
        }

        /// <summary>
        /// Lấy index của các properties trong dữ liệu
        /// </summary>
        /// <param name="objColumns">Các cột dữ liệu</param>
        /// <param name="objProperties">Các properties</param>
        /// <returns>Các index</returns>
        private static int[] ObjectPropertiesIndex(ArrayList objColumns, PropertyInfo[] objProperties)
        {
            int[] objIndex = new int[objProperties.Length];
            for (int i = 0; i < objProperties.Length; i++)
                objIndex[i] = objColumns.IndexOf(objProperties[i].Name);
            return objIndex;
        }

        /// <summary>
        /// Tạo một đối tượng
        /// </summary>
        /// <param name="objIDataReader">Dữ liệu dùng tạo đối tượng</param>
        /// <param name="objProperties">Các properties của đối tượng</param>
        /// <param name="objPropertiesIndex">Các index của properties của đối tượng</param>
        /// <param name="objType">Kiểu của đối tượng</param>
        /// <returns>Đối tượng được tạo</returns>
        private static object CreateObject(IDataReader objIDataReader, PropertyInfo[] objProperties, int[] objPropertiesIndex, Type objType)
        {
            // Đối tượng sẽ được trả về
            object objResult = Activator.CreateInstance(objType);
            for (int i = 0; i < objProperties.Length; i++)
            {
                if (objProperties[i].CanWrite == true)
                {
                    if (objPropertiesIndex[i] >= 0)
                    {
                        object objDataValue = objIDataReader.GetValue(objPropertiesIndex[i]);
                        Type objDataValueType = objDataValue.GetType();
                        Type objPropertiesType = objProperties[i].PropertyType;
                        if (Convert.IsDBNull(objDataValue) == false)
                        {
                            if (objDataValueType.Equals(objPropertiesType))
                                objProperties[i].SetValue(objResult, objDataValue, null);
                            else
                                objProperties[i].SetValue(objResult, Convert.ChangeType(objDataValue, objPropertiesType), null);
                        }
                    }
                }
            }
            return objResult;
        }

        /// <summary>
        /// Lấy thông tin của một object từ IDataReader (IDataReader sẽ được đóng sau khi FillObject)
        /// </summary>
        /// <param name="objIDataReader">DataReader</param>
        /// <param name="objType">Kiểu dữ liệu của object</param>
        /// <returns>Thông tin của object</returns>
        public static object FillObject(IDataReader objIDataReader, Type objType)
        {
            return CBO.FillObject(objIDataReader, objType, true);
        }

        /// <summary>
        /// Lấy thông tin của một object từ IDataReader
        /// </summary>
        /// <param name="objIDataReader">DataReader</param>
        /// <param name="objType">Kiểu dữ liệu của object</param>
        /// <param name="closeDataReader">Chỉ định xem có đóng IDataReader sau khi FillObject hay không?</param>
        /// <returns>Thông tin của object</returns>
        public static object FillObject(IDataReader objIDataReader, Type objType, bool closeDataReader)
        {
            object objResult = null;
            if (objIDataReader.Read() == true)
            {
                PropertyInfo[] objProperties = CBO.ObjectProperties(objType);
                ArrayList objColumns = CBO.TableColumns(objIDataReader);
                int[] objPropertiesIndex = CBO.ObjectPropertiesIndex(objColumns, objProperties);
                objResult = CBO.CreateObject(objIDataReader, objProperties, objPropertiesIndex, objType);
            }
            if (closeDataReader == true)
            {
                objIDataReader.Close();
                objIDataReader.Dispose();
            }
            return objResult;
        }

        /// <summary>
        /// Lấy thông tin của các object từ IDataReader (IDataReader sẽ được đóng sau khi FillCollection)
        /// </summary>
        /// <param name="objIDataReader">DataReader</param>
        /// <param name="objType">Kiểu dữ liệu của object</param>
        /// <returns>Thông tin của các object</returns>
        public static ArrayList FillCollection(IDataReader objIDataReader, Type objType)
        {
            return CBO.FillCollection(objIDataReader, objType, true);
        }

        /// <summary>
        /// Lấy thông tin của các object từ IDataReader
        /// </summary>
        /// <param name="objIDataReader">DataReader</param>
        /// <param name="objType">Kiểu dữ liệu của object</param>
        /// <param name="closeDataReader">Chỉ định xem có đóng IDataReader sau khi FillCollection hay không?</param>
        /// <returns>Thông tin của các object</returns>
        public static ArrayList FillCollection(IDataReader objIDataReader, Type objType, bool closeDataReader)
        {
            ArrayList objResult = new ArrayList();
            PropertyInfo[] objProperties = CBO.ObjectProperties(objType);
            ArrayList objColumns = CBO.TableColumns(objIDataReader);
            int[] objPropertiesIndex = CBO.ObjectPropertiesIndex(objColumns, objProperties);
            while (objIDataReader.Read() == true)
                objResult.Add(CreateObject(objIDataReader, objProperties, objPropertiesIndex, objType));
            if (closeDataReader == true)
            {
                objIDataReader.Close();
                objIDataReader.Dispose();
            }
            return objResult;
        }
    }
}
