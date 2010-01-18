using System;
using System.Collections.Generic;
using System.Text;

namespace CtyHongPhat
{
    /// <summary>
    /// Hiển thị các dạng thông báo
    /// </summary>
    public class MessageBox
    {
        public static void Error(System.Windows.Forms.IWin32Window owner, string message)
        {
            try
            {
                new FormMessageBoxError(owner, message);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
            }
        }

        public static void Infor(System.Windows.Forms.IWin32Window owner, string message)
        {
            try
            {
                new FormMessageBoxInfo(owner, message);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
            }
        }

        public static System.Windows.Forms.DialogResult Quest(System.Windows.Forms.IWin32Window owner, string message, int line)
        {
            try
            {
                System.Windows.Forms.DialogResult r = new FormMessageBoxQuest(owner, message, line).DialogResult;
                return r;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return System.Windows.Forms.DialogResult.No;
            }
        }
    }
}