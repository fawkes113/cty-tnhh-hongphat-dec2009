/****** Object:  StoredProcedure [dbo].[AGENT_KIND_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENT_KIND_Delete]
GO
/****** Object:  StoredProcedure [dbo].[AGENT_KIND_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENT_KIND_Insert]
GO
/****** Object:  StoredProcedure [dbo].[AGENT_KIND_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENT_KIND_Select]
GO
/****** Object:  StoredProcedure [dbo].[AGENT_KIND_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENT_KIND_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[AGENT_KIND_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENT_KIND_Update]
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENTS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENTS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENTS_Select]
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENTS_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AGENTS_Update]
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BANK_DEBTS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BANK_DEBTS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BANK_DEBTS_Select]
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BANK_DEBTS_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BANK_DEBTS_Update]
GO
/****** Object:  StoredProcedure [dbo].[BANK_INTEREST_RATE_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BANK_INTEREST_RATE_Delete]
GO
/****** Object:  StoredProcedure [dbo].[BANK_INTEREST_RATE_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BANK_INTEREST_RATE_Insert]
GO
/****** Object:  StoredProcedure [dbo].[BANK_INTEREST_RATE_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BANK_INTEREST_RATE_Update]
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BUY_PRICE_Delete]
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BUY_PRICE_Insert]
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BUY_PRICE_Select]
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BUY_PRICE_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[BUY_PRICE_Update]
GO
/****** Object:  StoredProcedure [dbo].[DEBT_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DEBT_Delete]
GO
/****** Object:  StoredProcedure [dbo].[DEBT_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DEBT_Insert]
GO
/****** Object:  StoredProcedure [dbo].[DEBT_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DEBT_Select]
GO
/****** Object:  StoredProcedure [dbo].[DEBT_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DEBT_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[DEBT_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DEBT_Update]
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EMPLOYEES_Delete]
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EMPLOYEES_Insert]
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EMPLOYEES_Select]
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EMPLOYEES_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EMPLOYEES_Update]
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EXPENSE_Delete]
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EXPENSE_Insert]
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EXPENSE_Select]
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EXPENSE_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EXPENSE_Update]
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ITEMS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ITEMS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ITEMS_Select]
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ITEMS_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ITEMS_Update]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_BUY_DETAILS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_BUY_DETAILS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_BUY_DETAILS_Select]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_BUY_DETAILS_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_BUY_DETAILS_Update]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_DETAILS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_DETAILS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_DETAILS_Select]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_DETAILS_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDER_DETAILS_Update]
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDERS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDERS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDERS_Select]
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Select_ByCutomerId_FromDate_ToDate]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Select_ByCutomerId_FromDate_ToDate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDERS_Select_ByCutomerId_FromDate_ToDate]
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDERS_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ORDERS_Update]
GO
/****** Object:  StoredProcedure [dbo].[PACKS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PACKS_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PACKS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[PACKS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PACKS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PACKS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Packs_Select_FromDate_ToDate]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Packs_Select_FromDate_ToDate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Packs_Select_FromDate_ToDate]
GO
/****** Object:  StoredProcedure [dbo].[PACKS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PACKS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PACKS_Update]
GO
/****** Object:  StoredProcedure [dbo].[PARTNER_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNER_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PARTNER_Delete]
GO
/****** Object:  StoredProcedure [dbo].[PARTNERS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PARTNERS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[PARTNERS_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PARTNERS_Select]
GO
/****** Object:  StoredProcedure [dbo].[PARTNERS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PARTNERS_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[PARTNERS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PARTNERS_Update]
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PAY_SHEET_Delete]
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PAY_SHEET_Insert]
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PAY_SHEET_Select]
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PAY_SHEET_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PAY_SHEET_Update]
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_COSTS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_COSTS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PROFIT_COSTS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_COSTS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_COSTS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PROFIT_COSTS_Update]
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PROFIT_Delete]
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PROFIT_Insert]
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PROFIT_Select]
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PROFIT_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[PROFIT_Update]
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_Select]
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_Update]
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SELL_PRICE_Delete]
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SELL_PRICE_Insert]
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SELL_PRICE_Select]
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SELL_PRICE_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SELL_PRICE_Update]
GO
/****** Object:  StoredProcedure [dbo].[USERS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[USERS_Delete]
GO
/****** Object:  StoredProcedure [dbo].[USERS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[USERS_Insert]
GO
/****** Object:  StoredProcedure [dbo].[USERS_Select]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[USERS_Select]
GO
/****** Object:  StoredProcedure [dbo].[USERS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_SelectAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[USERS_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[USERS_Update]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[USERS_Update]
GO
/****** Object:  View [dbo].[VIEW_AGENTS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VIEW_AGENTS]'))
DROP VIEW [dbo].[VIEW_AGENTS]
GO
/****** Object:  View [dbo].[VIEW_ITEM_BUY_PRICE]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VIEW_ITEM_BUY_PRICE]'))
DROP VIEW [dbo].[VIEW_ITEM_BUY_PRICE]
GO
/****** Object:  View [dbo].[VIEW_ITEM_SELL_PRICE]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VIEW_ITEM_SELL_PRICE]'))
DROP VIEW [dbo].[VIEW_ITEM_SELL_PRICE]
GO
/****** Object:  View [dbo].[VIEW_ORDERS_SELL]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VIEW_ORDERS_SELL]'))
DROP VIEW [dbo].[VIEW_ORDERS_SELL]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS]') AND type in (N'U'))
DROP TABLE [dbo].[USERS]
GO
/****** Object:  Table [dbo].[SELL_PRICE]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]') AND type in (N'U'))
DROP TABLE [dbo].[SELL_PRICE]
GO
/****** Object:  Table [dbo].[RETURNED_ITEM_DETAILS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS]') AND type in (N'U'))
DROP TABLE [dbo].[RETURNED_ITEM_DETAILS]
GO
/****** Object:  Table [dbo].[PROFIT]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT]') AND type in (N'U'))
DROP TABLE [dbo].[PROFIT]
GO
/****** Object:  Table [dbo].[PROFIT_COSTS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_COSTS]') AND type in (N'U'))
DROP TABLE [dbo].[PROFIT_COSTS]
GO
/****** Object:  Table [dbo].[PAY_SHEET]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET]') AND type in (N'U'))
DROP TABLE [dbo].[PAY_SHEET]
GO
/****** Object:  Table [dbo].[PARTNERS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS]') AND type in (N'U'))
DROP TABLE [dbo].[PARTNERS]
GO
/****** Object:  Table [dbo].[PACKS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PACKS]') AND type in (N'U'))
DROP TABLE [dbo].[PACKS]
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS]') AND type in (N'U'))
DROP TABLE [dbo].[ORDERS]
GO
/****** Object:  Table [dbo].[ORDER_DETAILS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]') AND type in (N'U'))
DROP TABLE [dbo].[ORDER_DETAILS]
GO
/****** Object:  Table [dbo].[ORDER_BUY_DETAILS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS]') AND type in (N'U'))
DROP TABLE [dbo].[ORDER_BUY_DETAILS]
GO
/****** Object:  Table [dbo].[ITEMS]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS]') AND type in (N'U'))
DROP TABLE [dbo].[ITEMS]
GO
/****** Object:  Table [dbo].[EXPENSE]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE]') AND type in (N'U'))
DROP TABLE [dbo].[EXPENSE]
GO
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]') AND type in (N'U'))
DROP TABLE [dbo].[EMPLOYEES]
GO
/****** Object:  Table [dbo].[DEBT]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT]') AND type in (N'U'))
DROP TABLE [dbo].[DEBT]
GO
/****** Object:  Table [dbo].[BUY_PRICE]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]') AND type in (N'U'))
DROP TABLE [dbo].[BUY_PRICE]
GO
/****** Object:  Table [dbo].[BANK_INTEREST_RATE]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE]') AND type in (N'U'))
DROP TABLE [dbo].[BANK_INTEREST_RATE]
GO
/****** Object:  Table [dbo].[BANK_DEBTS]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS]') AND type in (N'U'))
DROP TABLE [dbo].[BANK_DEBTS]
GO
/****** Object:  Table [dbo].[AGENTS]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS]') AND type in (N'U'))
DROP TABLE [dbo].[AGENTS]
GO
/****** Object:  Table [dbo].[AGENT_KIND]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND]') AND type in (N'U'))
DROP TABLE [dbo].[AGENT_KIND]
GO
/****** Object:  Default [DF_AGENT_KIND_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AGENT_KIND_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[AGENT_KIND]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AGENT_KIND_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AGENT_KIND] DROP CONSTRAINT [DF_AGENT_KIND_Deleted]
END


End
GO
/****** Object:  Default [DF_AGENT_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AGENT_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[AGENTS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AGENT_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AGENTS] DROP CONSTRAINT [DF_AGENT_Deleted]
END


End
GO
/****** Object:  Default [DF_BANK_DEBTS_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BANK_DEBTS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BANK_DEBTS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BANK_DEBTS] DROP CONSTRAINT [DF_BANK_DEBTS_Deleted]
END


End
GO
/****** Object:  Default [DF_BANK_INTEREST_RATE_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BANK_INTEREST_RATE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BANK_INTEREST_RATE_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BANK_INTEREST_RATE] DROP CONSTRAINT [DF_BANK_INTEREST_RATE_Deleted]
END


End
GO
/****** Object:  Default [DF_BUY_PRICE_BuyPrice]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BUY_PRICE_BuyPrice]') AND parent_object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BUY_PRICE_BuyPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BUY_PRICE] DROP CONSTRAINT [DF_BUY_PRICE_BuyPrice]
END


End
GO
/****** Object:  Default [DF_BUY_PRICE_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BUY_PRICE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BUY_PRICE_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BUY_PRICE] DROP CONSTRAINT [DF_BUY_PRICE_Deleted]
END


End
GO
/****** Object:  Default [DF_Dept_OldDebtValue]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_OldDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_OldDebtValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_OldDebtValue]
END


End
GO
/****** Object:  Default [DF_Dept_NewDebtValue]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_NewDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_NewDebtValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_NewDebtValue]
END


End
GO
/****** Object:  Default [DF_Dept_Payment]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_Payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_Payment]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_Payment]
END


End
GO
/****** Object:  Default [DF_Dept_CurrentDebtValue]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_CurrentDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_CurrentDebtValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_CurrentDebtValue]
END


End
GO
/****** Object:  Default [DF_Dept_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] DROP CONSTRAINT [DF_Dept_Deleted]
END


End
GO
/****** Object:  Default [DF_Employee_Salary]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Employee_Salary]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Employee_Salary]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EMPLOYEES] DROP CONSTRAINT [DF_Employee_Salary]
END


End
GO
/****** Object:  Default [DF_Employee_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Employee_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Employee_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EMPLOYEES] DROP CONSTRAINT [DF_Employee_Deleted]
END


End
GO
/****** Object:  Default [DF_EXPENSE_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EXPENSE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXPENSE]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EXPENSE_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EXPENSE] DROP CONSTRAINT [DF_EXPENSE_Deleted]
END


End
GO
/****** Object:  Default [DF_ITEM_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ITEM_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ITEM_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ITEMS] DROP CONSTRAINT [DF_ITEM_Deleted]
END


End
GO
/****** Object:  Default [DF_ITEM_TotalQuantity]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ITEM_TotalQuantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ITEM_TotalQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ITEMS] DROP CONSTRAINT [DF_ITEM_TotalQuantity]
END


End
GO
/****** Object:  Default [DF_OrderBuyDetail_Quantity]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderBuyDetail_Quantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderBuyDetail_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDER_BUY_DETAILS] DROP CONSTRAINT [DF_OrderBuyDetail_Quantity]
END


End
GO
/****** Object:  Default [DF_OrderBuyDetail_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderBuyDetail_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderBuyDetail_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDER_BUY_DETAILS] DROP CONSTRAINT [DF_OrderBuyDetail_Deleted]
END


End
GO
/****** Object:  Default [DF_OrderDetail_Quantity]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderDetail_Quantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderDetail_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDER_DETAILS] DROP CONSTRAINT [DF_OrderDetail_Quantity]
END


End
GO
/****** Object:  Default [DF_OrderDetail_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderDetail_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderDetail_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDER_DETAILS] DROP CONSTRAINT [DF_OrderDetail_Deleted]
END


End
GO
/****** Object:  Default [DF_ORDERS_Total]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Total]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ORDERS_Total]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDERS] DROP CONSTRAINT [DF_ORDERS_Total]
END


End
GO
/****** Object:  Default [DF_ORDERS_Pay]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Pay]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ORDERS_Pay]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDERS] DROP CONSTRAINT [DF_ORDERS_Pay]
END


End
GO
/****** Object:  Default [DF_ORDERS_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ORDERS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDERS] DROP CONSTRAINT [DF_ORDERS_Deleted]
END


End
GO
/****** Object:  Default [DF_ORDERS_VAT]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_VAT]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ORDERS_VAT]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDERS] DROP CONSTRAINT [DF_ORDERS_VAT]
END


End
GO
/****** Object:  Default [DF_Packs_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Packs_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PACKS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Packs_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PACKS] DROP CONSTRAINT [DF_Packs_Deleted]
END


End
GO
/****** Object:  Default [DF_PARTNERS_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PARTNERS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PARTNERS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PARTNERS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PARTNERS] DROP CONSTRAINT [DF_PARTNERS_Deleted]
END


End
GO
/****** Object:  Default [DF_PAY_SHEET_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PAY_SHEET_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PAY_SHEET]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PAY_SHEET_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PAY_SHEET] DROP CONSTRAINT [DF_PAY_SHEET_Deleted]
END


End
GO
/****** Object:  Default [DF_PROFIT_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PROFIT_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROFIT]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PROFIT_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PROFIT] DROP CONSTRAINT [DF_PROFIT_Deleted]
END


End
GO
/****** Object:  Default [DF_PROFIT_COSTS_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PROFIT_COSTS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROFIT_COSTS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PROFIT_COSTS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PROFIT_COSTS] DROP CONSTRAINT [DF_PROFIT_COSTS_Deleted]
END


End
GO
/****** Object:  Default [DF_RETURNED_ITEM_DETAILS_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_RETURNED_ITEM_DETAILS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_RETURNED_ITEM_DETAILS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[RETURNED_ITEM_DETAILS] DROP CONSTRAINT [DF_RETURNED_ITEM_DETAILS_Deleted]
END


End
GO
/****** Object:  Default [DF_SELL_PRICE_SellPrice]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SELL_PRICE_SellPrice]') AND parent_object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SELL_PRICE_SellPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SELL_PRICE] DROP CONSTRAINT [DF_SELL_PRICE_SellPrice]
END


End
GO
/****** Object:  Default [DF_SELL_PRICE_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SELL_PRICE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SELL_PRICE_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SELL_PRICE] DROP CONSTRAINT [DF_SELL_PRICE_Deleted]
END


End
GO
/****** Object:  Default [DF_USER_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_USER_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[USERS]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_USER_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[USERS] DROP CONSTRAINT [DF_USER_Deleted]
END


End
GO
/****** Object:  Table [dbo].[AGENT_KIND]    Script Date: 03/31/2010 16:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AGENT_KIND](
	[AgentKindId] [int] IDENTITY(1,1) NOT NULL,
	[AgentKindName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_AGENT_KIND] PRIMARY KEY CLUSTERED 
(
	[AgentKindId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[AGENT_KIND] ON
INSERT [dbo].[AGENT_KIND] ([AgentKindId], [AgentKindName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (1, N'Dai_ly_cap1', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
INSERT [dbo].[AGENT_KIND] ([AgentKindId], [AgentKindName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (2, N'Dai_ly_cap2', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[AGENT_KIND] OFF
/****** Object:  Table [dbo].[AGENTS]    Script Date: 03/31/2010 16:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AGENTS](
	[AgentId] [int] IDENTITY(1,1) NOT NULL,
	[AgentName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[AgentKindId] [int] NOT NULL,
	[Deleted] [int] NOT NULL,
	[Telephone] [nchar](15) COLLATE Vietnamese_CI_AS NULL,
	[Address] [text] COLLATE Vietnamese_CI_AS NULL,
 CONSTRAINT [PK_AGENT] PRIMARY KEY CLUSTERED 
(
	[AgentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[AGENTS] ON
INSERT [dbo].[AGENTS] ([AgentId], [AgentName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [AgentKindId], [Deleted], [Telephone], [Address]) VALUES (10, N'đại lý 1', N'ADMIN', CAST(0x00009D400017D720 AS DateTime), N'', CAST(0x00009D400017D79D AS DateTime), 1, 0, N'090102121220   ', N'đ?a chi 1')
SET IDENTITY_INSERT [dbo].[AGENTS] OFF
/****** Object:  Table [dbo].[BANK_DEBTS]    Script Date: 03/31/2010 16:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BANK_DEBTS](
	[BankDebtId] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [nvarchar](250) COLLATE Vietnamese_CI_AS NOT NULL,
	[BorrowDate] [datetime] NOT NULL,
	[DebtAmount] [decimal](18, 0) NOT NULL,
	[PaidAmount] [decimal](18, 0) NOT NULL,
	[MaturityDate] [datetime] NOT NULL,
	[InterestRate] [decimal](18, 0) NOT NULL,
	[Deleted] [int] NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_BANK_DEBTS] PRIMARY KEY CLUSTERED 
(
	[BankDebtId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[BANK_DEBTS] ON
INSERT [dbo].[BANK_DEBTS] ([BankDebtId], [BankName], [BorrowDate], [DebtAmount], [PaidAmount], [MaturityDate], [InterestRate], [Deleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (1, N'Đông Á', CAST(0x00009C1B0170A444 AS DateTime), CAST(100000000 AS Decimal(18, 0)), CAST(1000000 AS Decimal(18, 0)), CAST(0x00009F510170A444 AS DateTime), CAST(1 AS Decimal(18, 0)), 0, N'FSADFSDA', CAST(0x00009D350170DED4 AS DateTime), N'FDSA', CAST(0x00009D36017B4C86 AS DateTime))
INSERT [dbo].[BANK_DEBTS] ([BankDebtId], [BankName], [BorrowDate], [DebtAmount], [PaidAmount], [MaturityDate], [InterestRate], [Deleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (2, N'SacomBank', CAST(0x00009B0A0171A3BC AS DateTime), CAST(100000000 AS Decimal(18, 0)), CAST(1000000 AS Decimal(18, 0)), CAST(0x00009D350171A48F AS DateTime), CAST(1 AS Decimal(18, 0)), 0, N'FAS', CAST(0x00009D3501720127 AS DateTime), N'FSADF', CAST(0x00009D37018AF19F AS DateTime))
INSERT [dbo].[BANK_DEBTS] ([BankDebtId], [BankName], [BorrowDate], [DebtAmount], [PaidAmount], [MaturityDate], [InterestRate], [Deleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (3, N'Đông Á', CAST(0x00009D3501723BA6 AS DateTime), CAST(2000000 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)), CAST(0x0000A11A01723AE8 AS DateTime), CAST(1 AS Decimal(18, 0)), 1, N'FSAD', CAST(0x00009D35017269DF AS DateTime), N'FSADF', CAST(0x00009D37018B13E4 AS DateTime))
INSERT [dbo].[BANK_DEBTS] ([BankDebtId], [BankName], [BorrowDate], [DebtAmount], [PaidAmount], [MaturityDate], [InterestRate], [Deleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (4, N'SHCB', CAST(0x00009D380174C60F AS DateTime), CAST(3000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0x00009D600174C54C AS DateTime), CAST(2 AS Decimal(18, 0)), 0, N'FSAD', CAST(0x00009D380174E93E AS DateTime), N'', CAST(0x00009D380174E93E AS DateTime))
SET IDENTITY_INSERT [dbo].[BANK_DEBTS] OFF
/****** Object:  Table [dbo].[BANK_INTEREST_RATE]    Script Date: 03/31/2010 16:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BANK_INTEREST_RATE](
	[BankInterestRateId] [int] IDENTITY(1,1) NOT NULL,
	[BankDebtId] [int] NOT NULL,
	[RateAmount] [decimal](18, 0) NOT NULL,
	[PayDate] [datetime] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[ModifiedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
	[PayAmount] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_BANK_INTEREST_RATE] PRIMARY KEY CLUSTERED 
(
	[BankInterestRateId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[BANK_INTEREST_RATE] ON
INSERT [dbo].[BANK_INTEREST_RATE] ([BankInterestRateId], [BankDebtId], [RateAmount], [PayDate], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted], [PayAmount]) VALUES (1, 2, CAST(1000000 AS Decimal(18, 0)), CAST(0x00009D36017A8042 AS DateTime), CAST(0x00009D36017A8042 AS DateTime), N'FDSA', N'', CAST(0x00009D36017A8042 AS DateTime), 0, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[BANK_INTEREST_RATE] ([BankInterestRateId], [BankDebtId], [RateAmount], [PayDate], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted], [PayAmount]) VALUES (2, 1, CAST(1000000 AS Decimal(18, 0)), CAST(0x00009D36017B4C7B AS DateTime), CAST(0x00009D36017B4C7B AS DateTime), N'FDSA', N'', CAST(0x00009D36017B4C7B AS DateTime), 0, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[BANK_INTEREST_RATE] ([BankInterestRateId], [BankDebtId], [RateAmount], [PayDate], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted], [PayAmount]) VALUES (3, 2, CAST(1000000 AS Decimal(18, 0)), CAST(0x00009D37018AF11E AS DateTime), CAST(0x00009D37018AF11E AS DateTime), N'FSADF', N'', CAST(0x00009D37018AF11E AS DateTime), 0, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[BANK_INTEREST_RATE] ([BankInterestRateId], [BankDebtId], [RateAmount], [PayDate], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted], [PayAmount]) VALUES (4, 3, CAST(20000 AS Decimal(18, 0)), CAST(0x00009D37018B0C17 AS DateTime), CAST(0x00009D37018B0C17 AS DateTime), N'FSADF', N'', CAST(0x00009D37018B0C17 AS DateTime), 0, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[BANK_INTEREST_RATE] ([BankInterestRateId], [BankDebtId], [RateAmount], [PayDate], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted], [PayAmount]) VALUES (5, 3, CAST(10000 AS Decimal(18, 0)), CAST(0x00009D37018B13E4 AS DateTime), CAST(0x00009D37018B13E4 AS DateTime), N'FSADF', N'', CAST(0x00009D37018B13E4 AS DateTime), 0, CAST(1000000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[BANK_INTEREST_RATE] OFF
/****** Object:  Table [dbo].[BUY_PRICE]    Script Date: 03/31/2010 16:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BUY_PRICE](
	[BuyId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[PartnerId] [int] NOT NULL,
	[BuyPrice] [decimal](18, 0) NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_BUY_PRICE] PRIMARY KEY CLUSTERED 
(
	[BuyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[BUY_PRICE] ON
INSERT [dbo].[BUY_PRICE] ([BuyId], [ItemId], [PartnerId], [BuyPrice], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (1, 1, 2, CAST(5000 AS Decimal(18, 0)), N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
INSERT [dbo].[BUY_PRICE] ([BuyId], [ItemId], [PartnerId], [BuyPrice], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (2, 1, 3, CAST(5500 AS Decimal(18, 0)), N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
INSERT [dbo].[BUY_PRICE] ([BuyId], [ItemId], [PartnerId], [BuyPrice], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (3, 2, 1, CAST(6000 AS Decimal(18, 0)), N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[BUY_PRICE] OFF
/****** Object:  Table [dbo].[DEBT]    Script Date: 03/31/2010 16:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DEBT](
	[DebtId] [int] IDENTITY(1,1) NOT NULL,
	[OldDebtValue] [decimal](18, 0) NOT NULL,
	[NewDebtValue] [decimal](18, 0) NOT NULL,
	[Payment] [decimal](18, 0) NOT NULL,
	[CurrentDebtValue] [decimal](18, 0) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Deleted] [int] NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[DebtKind] [int] NOT NULL,
	[Note] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Dept] PRIMARY KEY CLUSTERED 
(
	[DebtId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[DEBT] ON
INSERT [dbo].[DEBT] ([DebtId], [OldDebtValue], [NewDebtValue], [Payment], [CurrentDebtValue], [CustomerId], [Deleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [DebtKind], [Note]) VALUES (21, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(100000 AS Decimal(18, 0)), 10, 0, N'ADMIN', CAST(0x00009D400017D79E AS DateTime), N'', CAST(0x00009D400017D79E AS DateTime), 1, N'')
INSERT [dbo].[DEBT] ([DebtId], [OldDebtValue], [NewDebtValue], [Payment], [CurrentDebtValue], [CustomerId], [Deleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [DebtKind], [Note]) VALUES (22, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), 11, 0, N'ADMIN', CAST(0x00009D40001CD0B9 AS DateTime), N'', CAST(0x00009D40001CD0B9 AS DateTime), 2, N'')
SET IDENTITY_INSERT [dbo].[DEBT] OFF
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EMPLOYEES](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Salary] [decimal](18, 0) NOT NULL,
	[Deleted] [int] NOT NULL,
	[Position] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Birthday] [datetime] NULL,
	[Address] [text] COLLATE Vietnamese_CI_AS NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[EMPLOYEES] ON
INSERT [dbo].[EMPLOYEES] ([EmployeeId], [EmployeeName], [Salary], [Deleted], [Position], [Birthday], [Address]) VALUES (1, N'Hai ha', CAST(10000 AS Decimal(18, 0)), 0, N'GiamDoc', CAST(0x00007C9800000000 AS DateTime), N'')
INSERT [dbo].[EMPLOYEES] ([EmployeeId], [EmployeeName], [Salary], [Deleted], [Position], [Birthday], [Address]) VALUES (2, N'Nguyên Văn A', CAST(100000 AS Decimal(18, 0)), 1, N'Nhân viên', CAST(0x00007C9800000000 AS DateTime), N'')
INSERT [dbo].[EMPLOYEES] ([EmployeeId], [EmployeeName], [Salary], [Deleted], [Position], [Birthday], [Address]) VALUES (3, N'Nguyễn Văn B', CAST(10000 AS Decimal(18, 0)), 0, N'nhân viên', CAST(0x00007C9800000000 AS DateTime), N'sdfsadfjsdljflsdajkf')
INSERT [dbo].[EMPLOYEES] ([EmployeeId], [EmployeeName], [Salary], [Deleted], [Position], [Birthday], [Address]) VALUES (4, N'Nguyễn Văn C', CAST(10000 AS Decimal(18, 0)), 0, N'Nhân viên', CAST(0x00007C9800000000 AS DateTime), N'')
INSERT [dbo].[EMPLOYEES] ([EmployeeId], [EmployeeName], [Salary], [Deleted], [Position], [Birthday], [Address]) VALUES (5, N'Nguyễn Văn D', CAST(10000 AS Decimal(18, 0)), 0, N'Nhân viên', CAST(0x00007C9800000000 AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[EMPLOYEES] OFF
/****** Object:  Table [dbo].[EXPENSE]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EXPENSE](
	[ExpenseId] [int] IDENTITY(1,1) NOT NULL,
	[FromDate] [datetime] NOT NULL,
	[ToDate] [datetime] NOT NULL,
	[Expense] [decimal](18, 0) NOT NULL,
	[Location] [text] COLLATE Vietnamese_CI_AS NOT NULL,
	[Deleted] [int] NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_EXPENSE] PRIMARY KEY CLUSTERED 
(
	[ExpenseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[ITEMS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ITEMS](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
	[TotalQuantity] [decimal](18, 0) NOT NULL,
	[Measurement] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_ITEM] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ITEMS] ON
INSERT [dbo].[ITEMS] ([ItemId], [ItemName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [TotalQuantity], [Measurement]) VALUES (1, N'Ac gap nhap', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'ADMIN', CAST(0x00009D40001F5B32 AS DateTime), 0, CAST(80 AS Decimal(18, 0)), N'Dream/wave')
INSERT [dbo].[ITEMS] ([ItemId], [ItemName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [TotalQuantity], [Measurement]) VALUES (2, N'bac dan 6000', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'FADS', CAST(0x00009D0F001F5FDC AS DateTime), 0, CAST(20 AS Decimal(18, 0)), N'Dream/wave')
INSERT [dbo].[ITEMS] ([ItemId], [ItemName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [TotalQuantity], [Measurement]) VALUES (3, N'Bo noi', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0, CAST(50 AS Decimal(18, 0)), N'Cub 50/70')
INSERT [dbo].[ITEMS] ([ItemId], [ItemName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [TotalQuantity], [Measurement]) VALUES (4, N'Cao su gac chan', N'ghaiha', CAST(0x00009D6900000000 AS DateTime), N'admin', CAST(0x00009D2F00000000 AS DateTime), 0, CAST(50 AS Decimal(18, 0)), N'DR/W/Cup')
INSERT [dbo].[ITEMS] ([ItemId], [ItemName], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [TotalQuantity], [Measurement]) VALUES (5, N'test 1', N'admin', CAST(0x00009D3800000000 AS DateTime), N'admin', CAST(0x00009D3800000000 AS DateTime), 0, CAST(0 AS Decimal(18, 0)), N'đơn vị 1')
SET IDENTITY_INSERT [dbo].[ITEMS] OFF
/****** Object:  Table [dbo].[ORDER_BUY_DETAILS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ORDER_BUY_DETAILS](
	[OrderBuyDetailId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quantity] [decimal](18, 0) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
	[Note] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_OrderBuyDetail] PRIMARY KEY CLUSTERED 
(
	[OrderBuyDetailId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ORDER_BUY_DETAILS] ON
INSERT [dbo].[ORDER_BUY_DETAILS] ([OrderBuyDetailId], [OrderId], [ItemId], [Quantity], [Price], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted], [Note]) VALUES (1, 22, 1, CAST(50 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), N'ADMIN', CAST(0x00009D40001F49C4 AS DateTime), N'', CAST(0x00009D40001F49EF AS DateTime), 0, N'')
SET IDENTITY_INSERT [dbo].[ORDER_BUY_DETAILS] OFF
/****** Object:  Table [dbo].[ORDER_DETAILS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ORDER_DETAILS](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quantity] [decimal](18, 0) NOT NULL,
	[IdPrice] [int] NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
	[Note] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ORDERS](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderKind] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Total] [decimal](18, 0) NOT NULL,
	[Pay] [decimal](18, 0) NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Deleted] [int] NOT NULL,
	[Vat] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ORDERS] ON
INSERT [dbo].[ORDERS] ([OrderId], [OrderKind], [CustomerId], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Total], [Pay], [Status], [Note], [Deleted], [Vat]) VALUES (22, 2, 11, N'ADMIN', CAST(0x00009D40001F5A2C AS DateTime), N'', CAST(0x00009D40001F5B2D AS DateTime), CAST(500000 AS Decimal(18, 0)), CAST(500000 AS Decimal(18, 0)), 2, N'', 0, CAST(0 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[ORDERS] OFF
/****** Object:  Table [dbo].[PACKS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PACKS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PACKS](
	[PackId] [int] IDENTITY(1,1) NOT NULL,
	[PackName] [nvarchar](250) COLLATE Vietnamese_CI_AS NOT NULL,
	[Quantity] [decimal](18, 0) NOT NULL,
	[ImportDate] [datetime] NOT NULL,
	[TotalAmount] [decimal](18, 0) NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_Packs] PRIMARY KEY CLUSTERED 
(
	[PackId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PACKS] ON
INSERT [dbo].[PACKS] ([PackId], [PackName], [Quantity], [ImportDate], [TotalAmount], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (1, N'loai a', CAST(500 AS Decimal(18, 0)), CAST(0x00009D1E01794414 AS DateTime), CAST(100 AS Decimal(18, 0)), N'FSAD', CAST(0x00009D3401796991 AS DateTime), N'', CAST(0x00009D3401796991 AS DateTime), 0)
INSERT [dbo].[PACKS] ([PackId], [PackName], [Quantity], [ImportDate], [TotalAmount], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (2, N'loai A', CAST(50000 AS Decimal(18, 0)), CAST(0x00009D1E0179BF20 AS DateTime), CAST(2000000 AS Decimal(18, 0)), N'FDSA', CAST(0x00009D340179DB6E AS DateTime), N'', CAST(0x00009D340179DCE3 AS DateTime), 0)
INSERT [dbo].[PACKS] ([PackId], [PackName], [Quantity], [ImportDate], [TotalAmount], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (3, N'loai A', CAST(50000 AS Decimal(18, 0)), CAST(0x00009D1E017A2AF0 AS DateTime), CAST(200000 AS Decimal(18, 0)), N'FADS', CAST(0x00009D34017A40D1 AS DateTime), N'', CAST(0x00009D34017A40D1 AS DateTime), 0)
INSERT [dbo].[PACKS] ([PackId], [PackName], [Quantity], [ImportDate], [TotalAmount], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (4, N'loai B', CAST(50000 AS Decimal(18, 0)), CAST(0x00009D20017A2AF0 AS DateTime), CAST(200000 AS Decimal(18, 0)), N'FADS', CAST(0x00009D34017A5425 AS DateTime), N'', CAST(0x00009D34017A5425 AS DateTime), 0)
INSERT [dbo].[PACKS] ([PackId], [PackName], [Quantity], [ImportDate], [TotalAmount], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (5, N'loai C', CAST(60000 AS Decimal(18, 0)), CAST(0x00009D2C017A2AF0 AS DateTime), CAST(250000 AS Decimal(18, 0)), N'FADS', CAST(0x00009D34017A61D4 AS DateTime), N'DFSA', CAST(0x00009D340185DB39 AS DateTime), 0)
INSERT [dbo].[PACKS] ([PackId], [PackName], [Quantity], [ImportDate], [TotalAmount], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (6, N'loai D', CAST(70000 AS Decimal(18, 0)), CAST(0x00009D34017A2AF0 AS DateTime), CAST(280000 AS Decimal(18, 0)), N'FADS', CAST(0x00009D34017A6EB5 AS DateTime), N'FDSA', CAST(0x00009D3401853C64 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[PACKS] OFF
/****** Object:  Table [dbo].[PARTNERS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PARTNERS](
	[PartnerId] [int] IDENTITY(1,1) NOT NULL,
	[PartnerName] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Address] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PhoneNumber] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_PARTNER] PRIMARY KEY CLUSTERED 
(
	[PartnerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PARTNERS] ON
INSERT [dbo].[PARTNERS] ([PartnerId], [PartnerName], [Address], [PhoneNumber], [Deleted]) VALUES (11, N'partner 1', N'địa chỉ', N'0900000', 0)
SET IDENTITY_INSERT [dbo].[PARTNERS] OFF
/****** Object:  Table [dbo].[PAY_SHEET]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PAY_SHEET](
	[PaySheetId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[Salary] [decimal](18, 0) NOT NULL,
	[WorkDays] [int] NOT NULL,
	[OverTime] [int] NOT NULL,
	[OverTimeSalary] [decimal](18, 0) NOT NULL,
	[Bonus] [decimal](18, 0) NOT NULL,
	[CreatedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[CreatedDate] [datetime] NULL,
	[Monthly] [nvarchar](50) COLLATE Vietnamese_CI_AS NOT NULL,
	[Deleted] [int] NULL,
 CONSTRAINT [PK_PAY_SHEET] PRIMARY KEY CLUSTERED 
(
	[PaySheetId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[PROFIT_COSTS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_COSTS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PROFIT_COSTS](
	[ProfitCostId] [int] NOT NULL,
	[CostType] [int] NOT NULL,
	[TotalAmount] [decimal](18, 0) NOT NULL,
	[PeriodType] [nvarchar](100) COLLATE Vietnamese_CI_AS NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[Deleted] [int] NOT NULL,
	[ProfitId] [int] NOT NULL,
 CONSTRAINT [PK_PROFIT_COSTS] PRIMARY KEY CLUSTERED 
(
	[ProfitCostId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[PROFIT]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PROFIT](
	[ProfitId] [int] IDENTITY(1,1) NOT NULL,
	[TotalRevenues] [decimal](18, 0) NOT NULL,
	[TotalCosts] [decimal](18, 0) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](250) COLLATE Vietnamese_CI_AS NULL,
	[Deleted] [int] NOT NULL,
	[Profits] [decimal](18, 0) NOT NULL,
	[PeriodTime] [nvarchar](100) COLLATE Vietnamese_CI_AS NOT NULL,
 CONSTRAINT [PK_PROFIT] PRIMARY KEY CLUSTERED 
(
	[ProfitId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[RETURNED_ITEM_DETAILS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RETURNED_ITEM_DETAILS](
	[ReturnedItemDetailsId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDetailId] [int] NOT NULL,
	[Quantity] [decimal](18, 0) NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
	[Note] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_RETURNED_ITEM_DETAILS] PRIMARY KEY CLUSTERED 
(
	[ReturnedItemDetailsId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[RETURNED_ITEM_DETAILS] ON
INSERT [dbo].[RETURNED_ITEM_DETAILS] ([ReturnedItemDetailsId], [OrderDetailId], [Quantity], [ReturnDate], [Note], [Deleted]) VALUES (1, 1, CAST(20 AS Decimal(18, 0)), CAST(0x00009D6900000000 AS DateTime), N'tra ve', 0)
SET IDENTITY_INSERT [dbo].[RETURNED_ITEM_DETAILS] OFF
/****** Object:  Table [dbo].[SELL_PRICE]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SELL_PRICE](
	[SellId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[AgentKindId] [int] NOT NULL,
	[SellPrice] [decimal](18, 0) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedBy] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK_SELL_PRICE] PRIMARY KEY CLUSTERED 
(
	[SellId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[SELL_PRICE] ON
INSERT [dbo].[SELL_PRICE] ([SellId], [ItemId], [AgentKindId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (1, 1, 1, CAST(7500 AS Decimal(18, 0)), CAST(0x00009D6900000000 AS DateTime), N'ghaiha', N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
INSERT [dbo].[SELL_PRICE] ([SellId], [ItemId], [AgentKindId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (2, 2, 1, CAST(7000 AS Decimal(18, 0)), CAST(0x00009D6900000000 AS DateTime), N'ghaiha', N'5/1/2010 12:00:00 AM', CAST(0x00009D6900000000 AS DateTime), 0)
INSERT [dbo].[SELL_PRICE] ([SellId], [ItemId], [AgentKindId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (3, 3, 1, CAST(7000 AS Decimal(18, 0)), NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[SELL_PRICE] ([SellId], [ItemId], [AgentKindId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (5, 1, 2, CAST(8000 AS Decimal(18, 0)), NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[SELL_PRICE] ([SellId], [ItemId], [AgentKindId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (6, 2, 2, CAST(8000 AS Decimal(18, 0)), NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[SELL_PRICE] ([SellId], [ItemId], [AgentKindId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (7, 3, 2, CAST(8000 AS Decimal(18, 0)), NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[SELL_PRICE] ([SellId], [ItemId], [AgentKindId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (9, 5, 1, CAST(9000 AS Decimal(18, 0)), CAST(0x00009D3800000000 AS DateTime), N'admin', N'admin', CAST(0x00009D3800000000 AS DateTime), 0)
INSERT [dbo].[SELL_PRICE] ([SellId], [ItemId], [AgentKindId], [SellPrice], [CreatedDate], [CreatedBy], [ModifiedBy], [ModifiedDate], [Deleted]) VALUES (10, 5, 2, CAST(10000 AS Decimal(18, 0)), CAST(0x00009D3800000000 AS DateTime), N'admin', N'admin', CAST(0x00009D3800000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[SELL_PRICE] OFF
/****** Object:  Table [dbo].[USERS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[USERS](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[UserPassword] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Deleted] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[USERS] ON
INSERT [dbo].[USERS] ([UserId], [UserName], [UserPassword], [Deleted], [EmployeeId]) VALUES (1, N'ghaiha', N'ghaiha', 0, 1)
INSERT [dbo].[USERS] ([UserId], [UserName], [UserPassword], [Deleted], [EmployeeId]) VALUES (2, N'ADMIN', N'nG^d`|#~GL', 0, 1)
SET IDENTITY_INSERT [dbo].[USERS] OFF
/****** Object:  View [dbo].[VIEW_ORDERS_SELL]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VIEW_ORDERS_SELL]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VIEW_ORDERS_SELL]
AS
SELECT     TOP (100) PERCENT dbo.ORDERS.OrderId, dbo.ORDERS.OrderKind, dbo.ORDERS.CustomerId, dbo.ORDER_DETAILS.OrderDetailId, dbo.ITEMS.ItemId, 
                      dbo.ITEMS.ItemName, dbo.ORDER_DETAILS.Quantity, dbo.SELL_PRICE.SellId, dbo.SELL_PRICE.SellPrice, 
                      dbo.ORDER_DETAILS.Quantity * dbo.SELL_PRICE.SellPrice AS Amount, dbo.ORDERS.Total, dbo.ORDERS.Pay
FROM         dbo.ITEMS INNER JOIN
                      dbo.ORDER_DETAILS ON dbo.ITEMS.ItemId = dbo.ORDER_DETAILS.ItemId INNER JOIN
                      dbo.ORDERS ON dbo.ORDER_DETAILS.OrderId = dbo.ORDERS.OrderId INNER JOIN
                      dbo.SELL_PRICE ON dbo.ITEMS.ItemId = dbo.SELL_PRICE.ItemId
WHERE     (dbo.ITEMS.Deleted = 0) AND (dbo.SELL_PRICE.Deleted = 0) AND (dbo.ORDER_DETAILS.Deleted = 0)
ORDER BY dbo.ORDERS.OrderId DESC
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VIEW_ORDERS_SELL', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ITEMS"
            Begin Extent = 
               Top = 46
               Left = 439
               Bottom = 274
               Right = 599
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ORDER_DETAILS"
            Begin Extent = 
               Top = 26
               Left = 210
               Bottom = 245
               Right = 370
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ORDERS"
            Begin Extent = 
               Top = 36
               Left = 0
               Bottom = 262
               Right = 160
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SELL_PRICE"
            Begin Extent = 
               Top = 6
               Left = 632
               Bottom = 231
               Right = 792
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_ORDERS_SELL'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VIEW_ORDERS_SELL', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_ORDERS_SELL'
GO
/****** Object:  View [dbo].[VIEW_ITEM_SELL_PRICE]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VIEW_ITEM_SELL_PRICE]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VIEW_ITEM_SELL_PRICE]
AS
SELECT     it.ItemId, it.ItemName, it.Measurement, it.TotalQuantity, sp.SellId, sp.SellPrice, akd.AgentKindId, akd.AgentKindName, it.CreatedBy, it.CreatedDate, it.ModifiedBy, 
                      it.ModifiedDate, it.Deleted
FROM         dbo.ITEMS AS it INNER JOIN
                      dbo.SELL_PRICE AS sp ON it.ItemId = sp.ItemId INNER JOIN
                      dbo.AGENT_KIND AS akd ON sp.AgentKindId = akd.AgentKindId
WHERE     (it.Deleted = 0) AND (sp.Deleted = 0) AND (akd.Deleted = 0)
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VIEW_ITEM_SELL_PRICE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "it"
            Begin Extent = 
               Top = 15
               Left = 410
               Bottom = 134
               Right = 570
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "sp"
            Begin Extent = 
               Top = 55
               Left = 51
               Bottom = 174
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "akd"
            Begin Extent = 
               Top = 140
               Left = 413
               Bottom = 259
               Right = 578
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_ITEM_SELL_PRICE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VIEW_ITEM_SELL_PRICE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_ITEM_SELL_PRICE'
GO
/****** Object:  View [dbo].[VIEW_ITEM_BUY_PRICE]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VIEW_ITEM_BUY_PRICE]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VIEW_ITEM_BUY_PRICE]
AS
SELECT     TOP (100) PERCENT it.ItemId, it.ItemName, it.Measurement, it.TotalQuantity, bp.BuyId, bp.BuyPrice, pn.PartnerId, pn.PartnerName
FROM         dbo.ITEMS AS it INNER JOIN
                      dbo.BUY_PRICE AS bp ON it.ItemId = bp.ItemId INNER JOIN
                      dbo.PARTNERS AS pn ON bp.PartnerId = pn.PartnerId
WHERE     (bp.Deleted = 0) AND (it.Deleted = 0) AND (pn.Deleted = 0)
ORDER BY it.ItemId DESC
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VIEW_ITEM_BUY_PRICE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "it"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "bp"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pn"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 125
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_ITEM_BUY_PRICE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VIEW_ITEM_BUY_PRICE', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_ITEM_BUY_PRICE'
GO
/****** Object:  View [dbo].[VIEW_AGENTS]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VIEW_AGENTS]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[VIEW_AGENTS]
AS
SELECT     ag.AgentId, ag.AgentName, agk.AgentKindId, agk.AgentKindName, d.DebtId, d.CurrentDebtValue, ag.CreatedBy, ag.CreatedDate, ag.ModifiedBy, ag.ModifiedDate, 
                      ag.Deleted
FROM         dbo.AGENTS AS ag INNER JOIN
                      dbo.AGENT_KIND AS agk ON ag.AgentKindId = agk.AgentKindId INNER JOIN
                      dbo.DEBT AS d ON ag.AgentId = d.CustomerId
WHERE     (ag.Deleted = 0) AND (agk.Deleted = 0) AND (d.Deleted = 0)
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'VIEW_AGENTS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ag"
            Begin Extent = 
               Top = 6
               Left = 241
               Bottom = 125
               Right = 401
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "agk"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 203
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 6
               Left = 439
               Bottom = 284
               Right = 664
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_AGENTS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'VIEW_AGENTS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_AGENTS'
GO
/****** Object:  StoredProcedure [dbo].[USERS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[USERS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[USERS_Update]
(
	@UserId int,
	@UserName nvarchar(50),
	@UserPassword nvarchar(50),
	@EmployeeId int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE USERS
	SET
		[UserName] = case when @UserName is null then [UserName] else @UserName end,
		[UserPassword] = case when @UserPassword is null then [UserPassword] else @UserPassword end,
		[EmployeeId] = case when @EmployeeId is null then [EmployeeId] else @EmployeeId end
	WHERE
		[UserId] = @UserId


END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[USERS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[USERS_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[USERS_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[UserId],
		[UserName],
		[UserPassword],
		[EmployeeId]
	FROM [USERS]	
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[USERS_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[USERS_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[USERS_Select]
(
	@UserId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[UserId],
		[UserName],
		[UserPassword],
		[EmployeeId]
	FROM [USERS]
	WHERE
		([UserId] = @UserId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[USERS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[USERS_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[USERS_Insert]
(
	@UserName nvarchar(50),
	@UserPassword nvarchar(50),
	@EmployeeId int
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [USERS]
	(
		[UserName],
		[UserPassword],
		[EmployeeId]
	)
	VALUES
	(
		@UserName,
		@UserPassword,
		@EmployeeId
	)
	SELECT SCOPE_IDENTITY()

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[USERS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[USERS_Delete]
(
	@UserId int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE USERS
	SET Deleted = 1

	WHERE
		[UserId] = @UserId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[SELL_PRICE_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[SELL_PRICE_Update]
(
	@SellId int,
	@ItemId int,
	@AgentKindId int,
	@SellPrice decimal(18,0),
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE SELL_PRICE
	SET
		[ItemId] = case when @ItemId is null then [ItemId] else @ItemId end,
		[AgentKindId] = case when @AgentKindId is null then [AgentKindId] else @AgentKindId end,
		[SellPrice] = case when @SellPrice is null then [SellPrice] else @SellPrice end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
	WHERE
		[SellId] = @SellId


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[SELL_PRICE_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[SELL_PRICE_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[SellId],
		[ItemId],
		[AgentKindId],
		[SellPrice],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate]
	FROM [SELL_PRICE]	
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[SELL_PRICE_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[SELL_PRICE_Select]
(
	@SellId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[SellId],
		[ItemId],
		[AgentKindId],
		[SellPrice],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate]
	FROM [SELL_PRICE]
	WHERE
		([SellId] = @SellId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[SELL_PRICE_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[SELL_PRICE_Insert]
(
	@ItemId int,
	@AgentKindId int,
	@SellPrice decimal(18,0),
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [SELL_PRICE]
	(
		[ItemId],
		[AgentKindId],
		[SellPrice],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate]
	)
	VALUES
	(
		@ItemId,
		@AgentKindId,
		@SellPrice,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SELL_PRICE_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SELL_PRICE_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SELL_PRICE_Delete]
(
	@SellId int,
	@ModifiedBy nvarchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE SELL_PRICE
	SET Deleted = 1, ModifiedBy = @ModifiedBy

	WHERE
		[SellId] = @SellId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[RETURNED_ITEM_DETAILS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_Update]
(
	@ReturnedItemDetailsId int,
	@OrderDetailId int,
	@Quantity decimal(18,0),
	@ReturnDate datetime,
	@Note text = NULL,
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE RETURNED_ITEM_DETAILS
	SET
		[OrderDetailId] = case when @OrderDetailId is null then [OrderDetailId] else @OrderDetailId end,
		[Quantity] = case when @Quantity is null then [Quantity] else @Quantity end,
		[ReturnDate] = case when @ReturnDate is null then [ReturnDate] else @ReturnDate end,
		[Note] = case when @Note is null then [Note] else @Note end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
	WHERE
		[ReturnedItemDetailsId] = @ReturnedItemDetailsId


END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[RETURNED_ITEM_DETAILS_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[ReturnedItemDetailsId],
		[OrderDetailId],
		[Quantity],
		[ReturnDate],
		[Note],
		[Deleted]
	FROM [RETURNED_ITEM_DETAILS]	
	
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[RETURNED_ITEM_DETAILS_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_Select]
(
	@ReturnedItemDetailsId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[ReturnedItemDetailsId],
		[OrderDetailId],
		[Quantity],
		[ReturnDate],
		[Note],
		[Deleted]
	FROM [RETURNED_ITEM_DETAILS]
	WHERE
		([ReturnedItemDetailsId] = @ReturnedItemDetailsId)

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[RETURNED_ITEM_DETAILS_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_Insert]
(
	@OrderDetailId int,
	@Quantity decimal(18,0),
	@ReturnDate datetime,
	@Note text = NULL,
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [RETURNED_ITEM_DETAILS]
	(
		[OrderDetailId],
		[Quantity],
		[ReturnDate],
		[Note],
		[Deleted]
	)
	VALUES
	(
		@OrderDetailId,
		@Quantity,
		@ReturnDate,
		@Note,
		@Deleted
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[RETURNED_ITEM_DETAILS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[RETURNED_ITEM_DETAILS_Delete]
(
	@ReturnedItemDetailsId int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE RETURNED_ITEM_DETAILS
	SET Deleted = 1

	WHERE
		[ReturnedItemDetailsId] = @ReturnedItemDetailsId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[PROFIT_Update]
(
	@ProfitId int,
	@TotalRevenues decimal,
	@TotalCosts decimal,
	@CreatedDate datetime = NULL,
	@CreatedBy nvarchar(250) = NULL,
	@Deleted int,
	@Profits decimal,
	@PeriodTime nvarchar(100) = NULL
)	
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE PROFIT
	SET
		[TotalRevenues] = case when @TotalRevenues is null then [TotalRevenues] else @TotalRevenues end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[TotalCosts] = case when @TotalCosts is null then [TotalCosts] else @TotalCosts end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end,
		[Profits] = case when @Profits is null then [Profits] else @Profits end,
		[PeriodTime] = case when @PeriodTime is null then [PeriodTime] else @PeriodTime end
	WHERE
		[ProfitId] = @ProfitId
END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[PROFIT_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[ProfitId],
		[TotalRevenues],
		[TotalCosts],
		[CreatedDate],
		[CreatedBy],
		[Deleted],
		[Profits],
		[PeriodTime]
	FROM [PROFIT]	
	 WHERE ([Deleted] = 0)
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[PROFIT_Select]
(
	@ProfitId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[ProfitId],
		[TotalRevenues],
		[TotalCosts],
		[CreatedDate],
		[CreatedBy],
		[Deleted],
		[Profits],
		[PeriodTime]
	FROM [PROFIT]
	WHERE
		([ProfitId] = @ProfitId) AND	([Deleted] = 0)

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[AGENT_KIND_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[PROFIT_Insert]
(
	@TotalRevenues decimal,
	@TotalCosts decimal,
	@CreatedDate datetime = NULL,
	@CreatedBy nvarchar(250) = NULL,
	@Deleted int,
	@Profits decimal,
	@PeriodTime nvarchar(100) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [PROFIT]
	(
		[TotalRevenues],
		[TotalCosts],
		[CreatedDate],
		[CreatedBy],
		[Deleted],
		[Profits],
		[PeriodTime]
	)
	VALUES
	(
		@TotalRevenues,
		@TotalCosts,
		@CreatedDate,
		@CreatedBy,
		@Deleted,
		@Profits,
		@PeriodTime
	)
	SELECT SCOPE_IDENTITY()

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[PROFIT_Delete]
(
	@ProfitId int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE PROFIT
	SET Deleted = 1

	WHERE
		[ProfitId] = @ProfitId
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_COSTS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_COSTS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[PROFIT_COSTS_Update]
(
	@ProfitCostId int,
	@CostType int,
	@TotalAmount decimal,
	@PeriodType nvarchar(100) = NULL,
	@CreatedDate datetime = NULL,
	@CreatedBy nvarchar(250) = NULL,
	@Deleted int,
	@ProfitId int
)	
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE PROFIT_COSTS
	SET
		[CostType] = case when @CostType is null then [CostType] else @CostType end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[TotalAmount] = case when @TotalAmount is null then [TotalAmount] else @TotalAmount end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end,
		[ProfitId] = case when @ProfitId is null then [ProfitId] else @ProfitId end,
		[periodType] = case when @periodType is null then [periodType] else @periodType end
	WHERE
		[ProfitCostId] = @ProfitCostId
END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[PROFIT_COSTS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFIT_COSTS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[AGENT_KIND_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[PROFIT_COSTS_Insert]
(
	@CostType int,
	@TotalAmount decimal,
	@PeriodType nvarchar(100) = NULL,
	@CreatedDate datetime = NULL,
	@CreatedBy nvarchar(250) = NULL,
	@Deleted int,
	@ProfitId int
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [PROFIT_COSTS]
	(
		[CostType],
		[TotalAmount],
		[PeriodType],
		[CreatedDate],
		[CreatedBy],
		[Deleted],
		[ProfitId]
	)
	VALUES
	(
		@CostType,
		@TotalAmount,
		@PeriodType,
		@CreatedDate,
		@CreatedBy,
		@Deleted,
		@ProfitId
	)
	SELECT SCOPE_IDENTITY()

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[PAY_SHEET_Update]
(
	@PaySheetId int,
	@EmployeeId int,
	@Salary decimal,
	@WorkDays int,
	@OverTime int,
	@OverTimeSalary decimal,
	@Bonus decimal,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime,
	@Monthly nvarchar(50) = NULL,
	@Deleted int
)	
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE PAY_SHEET
	SET
		[EmployeeId] = case when @EmployeeId is null then [EmployeeId] else @EmployeeId end,
		[Salary] = case when @Salary is null then [Salary] else @Salary end,
		[WorkDays] = case when @WorkDays is null then [WorkDays] else @WorkDays end,
		[OverTime] = case when @OverTime is null then [OverTime] else @OverTime end,
		[OverTimeSalary] = case when @OverTimeSalary is null then [OverTimeSalary] else @OverTimeSalary end,
		[Bonus] = case when @Bonus is null then [Bonus] else @Bonus end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[Monthly] = case when @Monthly is null then [Monthly] else @Monthly end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
	WHERE
		[PaySheetId] = @PaySheetId


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[PAY_SHEET_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[PaySheetId],
		[EmployeeId],
		[Salary],
		[WorkDays],
		[OverTime],
		[OverTimeSalary],
		[Bonus],
		[CreatedBy],
		[CreatedDate],
		[Monthly]
	FROM  [PAY_SHEET]
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[PAY_SHEET_Select]
(
	@PaySheetId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[PaySheetId],
		[EmployeeId],
		[Salary],
		[WorkDays],
		[OverTime],
		[OverTimeSalary],
		[Bonus],
		[CreatedBy],
		[CreatedDate],
		[Monthly]
	FROM [PAY_SHEET]
	WHERE
		([PaySheetId] = @PaySheetId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[AGENT_KIND_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[PAY_SHEET_Insert]
(
	@EmployeeId int,
	@Salary decimal,
	@WorkDays int,
	@OverTime int,
	@OverTimeSalary decimal,
	@Bonus decimal,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime,
	@Monthly nvarchar(50) = NULL, 
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [PAY_SHEET]
	(
		[EmployeeId],
		[Salary],
		[WorkDays],
		[OverTime],
		[OverTimeSalary],
		[Bonus],
		[CreatedBy],
		[CreatedDate],
		[Monthly],
		[Deleted]
	)
	VALUES
	(
		@EmployeeId,
		@Salary,
		@WorkDays,
		@OverTime,
		@OverTimeSalary,
		@Bonus,
		@CreatedBy,
		@CreatedDate,
		@Monthly,
		@Deleted
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[PAY_SHEET_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PAY_SHEET_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[PAY_SHEET_Delete]
(
	@PaySheetId int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE PAY_SHEET
	SET Deleted = 1

	WHERE
		[PaySheetId] = @PaySheetId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[PARTNERS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[PARTNERS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[PARTNERS_Update]
(
	@PartnerId int,
	@PartnerName nvarchar(250),
	@Address nvarchar(250),
	@PhoneNumber nvarchar(50),
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE PARTNERS
	SET
		[PartnerName] = case when @PartnerName is null then [PartnerName] else @PartnerName end,
		[Address] = case when @Address is null then [Address] else @Address end,
		[PhoneNumber] = case when @PhoneNumber is null then [PhoneNumber] else @PhoneNumber end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
	WHERE
		[PartnerId] = @PartnerId


END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[PARTNERS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[PARTNERS_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[PARTNERS_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[PartnerId],
		[PartnerName],
		[Address],
		[PhoneNumber]
	FROM [PARTNERS]	
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[PARTNERS_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[PARTNERS_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[PARTNERS_Select]
(
	@PartnerId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[PartnerId],
		[PartnerName],
		[Address],
		[PhoneNumber]
	FROM [PARTNERS]
	WHERE
		([PartnerId] = @PartnerId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[PARTNERS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNERS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[PARTNERS_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[PARTNERS_Insert]
(
	@PartnerName nvarchar(250),
	@Address nvarchar(250),
	@PhoneNumber nvarchar(50),
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [PARTNERS]
	(
		[PartnerName],
		[Address],
		[PhoneNumber],
		[Deleted]
	)
	VALUES
	(
		@PartnerName,
		@Address,
		@PhoneNumber,
		@Deleted
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[PARTNER_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PARTNER_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[PARTNER_Delete]
(
	@PartnerId int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE PARTNERS
	SET Deleted = 1

	WHERE
		[PartnerId] = @PartnerId
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[PACKS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PACKS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENTS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[PACKS_Update]
(
	@PackId int,
	@PackName nvarchar(250) = NULL,
	@Quantity decimal,
	@ImportDate datetime = NULL,
	@TotalAmount decimal,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE PACKS
	SET
		[PackName] = case when @PackName is null then [PackName] else @PackName end,
		[Quantity] = case when @Quantity is null then [Quantity] else @Quantity end,
		[ImportDate] = case when @ImportDate is null then [ImportDate] else @ImportDate end,
		[TotalAmount] = case when @TotalAmount is null then [TotalAmount] else @TotalAmount end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
		
	WHERE
		[PackId] = @PackId


END





' 
END
GO
/****** Object:  StoredProcedure [dbo].[Packs_Select_FromDate_ToDate]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Packs_Select_FromDate_ToDate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[Packs_Select_FromDate_ToDate](
	@FromDate datetime,
	@ToDate datetime
)
as
begin
	select * from Packs
	where ImportDate >= @FromDate
	and ImportDate <= @ToDate
	and deleted = 0
	order by ImportDate desc
end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[PACKS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PACKS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[AGENT_KIND_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[PACKS_Insert]
(
	@PackName nvarchar(250),
	@Quantity decimal,
	@ImportDate	datetime = NULL,
	@TotalAmount decimal,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [PACKS]
	(
		[PackName],
		[Quantity],
		[ImportDate],
		[TotalAmount],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate]
	)
	VALUES
	(
		@PackName,
		@Quantity,
		@ImportDate,
		@TotalAmount,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate
	)
	SELECT SCOPE_IDENTITY()

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[PACKS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PACKS_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[PACKS_Delete]
(
	@PackId int,
	@ModifiedBy nvarchar(20),
	@ModifiedDate datetime
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE PACKS
	SET Deleted = 1, ModifiedBy = @ModifiedBy, ModifiedDate = @ModifiedDate

	WHERE
		[PackId] = @PackId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ORDERS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDERS_Update]
(
	@OrderId int,
	@OrderKind int,
	@CustomerId int,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Total decimal(18,0),
	@Pay decimal(18,0),
	@Status int,
	@Note text,
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE ORDERS
	SET
		[OrderKind] = case when @OrderKind is null then [OrderKind] else @OrderKind end,
		[CustomerId] = case when @CustomerId is null then [CustomerId] else @CustomerId end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Total] = case when @Total is null then [Total] else @Total end,
		[Pay] = case when @Pay is null then [Pay] else @Pay end,
		[Status] = case when @Status is null then [Status] else @Status end,
		[Note] = case when @Note is null then [Note] else @Note end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
	WHERE
		[OrderId] = @OrderId


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ORDERS_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDERS_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[OrderId],
		[OrderKind],
		[CustomerId],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[Total],
		[Pay],
		[Status],
		[Note],
		[Deleted]
	FROM [ORDERS]	
	
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Select_ByCutomerId_FromDate_ToDate]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Select_ByCutomerId_FromDate_ToDate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[ORDERS_Select_ByCutomerId_FromDate_ToDate]
(
	@CustomerId int,
	@OrderKind int,
	@Status int,
	@FromDate datetime,
	@ToDate datetime
)
as
begin
	if(@CustomerId = -1)
	begin
		if(@Status = -1)
		begin
			select * from Orders 
			where OrderKind = @OrderKind
				and CreatedDate >= @FromDate
				and CreatedDate <= @ToDate
				and Deleted = 0
			order by CreatedDate
		end
		else
			select * from Orders 
			where OrderKind = @OrderKind
				and Status = @Status
				and CreatedDate >= @FromDate
				and CreatedDate <= @ToDate
				and Deleted = 0
			order by CreatedDate
	end
	else 
	begin
		if(@Status = -1)
		begin
			select * from Orders 
			where CustomerId = @CustomerId
				and OrderKind = @OrderKind
				and CreatedDate >= @FromDate
				and CreatedDate <= @ToDate
				and Deleted = 0
			order by CreatedDate
		end
		else
			select * from Orders 
			where CustomerId = @CustomerId
				and OrderKind = @OrderKind
				and Status = @Status
				and CreatedDate >= @FromDate
				and CreatedDate <= @ToDate
				and Deleted = 0
			order by CreatedDate
	end
end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ORDERS_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDERS_Select]
(
	@OrderId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[OrderId],
		[OrderKind],
		[CustomerId],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[Total],
		[Pay],
		[Status],
		[Note],
		[Deleted]
	FROM [ORDERS]
	WHERE
		([OrderId] = @OrderId)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[ORDERS_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDERS_Insert]
(
	@OrderKind int,
	@CustomerId int,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Total decimal(18,0),
	@Pay decimal(18,0),
	@Status int,
	@Note text,
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [ORDERS]
	(
		[OrderKind],
		[CustomerId],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[Total],
		[Pay],
		[Status],
		[Note],
		[Deleted]
	)
	VALUES
	(
		@OrderKind,
		@CustomerId,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate,
		@Total,
		@Pay,
		@Status,
		@Note,
		@Deleted
	)
	SELECT SCOPE_IDENTITY()

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDERS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDERS_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ORDERS_Delete]
(
	@OrderId int,
	@ModifiedBy nvarchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE ORDERS
	SET Deleted = 1, ModifiedBy = @ModifiedBy

	WHERE
		[OrderId] = @OrderId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ORDER_DETAILS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDER_DETAILS_Update]
(
	@OrderDetailId int,
	@OrderId int,
	@ItemId int,
	@Quantity decimal(18,0),
	@IdPrice int,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Deleted int,
	@Note text = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE ORDER_DETAILS
	SET
		[OrderId] = case when @OrderId is null then [OrderId] else @OrderId end,
		[ItemId] = case when @ItemId is null then [ItemId] else @ItemId end,
		[Quantity] = case when @Quantity is null then [Quantity] else @Quantity end,
		[IdPrice] = case when @IdPrice is null then [IdPrice] else @IdPrice end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end,
		[Note] = case when @Note is null then [Note] else @Note end
	WHERE
		[OrderDetailId] = @OrderDetailId


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ORDER_DETAILS_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDER_DETAILS_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[OrderDetailId],
		[OrderId],
		[ItemId],
		[Quantity],
		[IdPrice],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[Note]
	FROM [ORDER_DETAILS]	
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ORDER_DETAILS_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDER_DETAILS_Select]
(
	@OrderDetailId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[OrderDetailId],
		[OrderId],
		[ItemId],
		[Quantity],
		[IdPrice],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[Note]
	FROM [ORDER_DETAILS]
	WHERE
		([OrderDetailId] = @OrderDetailId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[ORDER_DETAILS_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDER_DETAILS_Insert]
(
	@OrderId int,
	@ItemId int,
	@Quantity decimal(18,0),
	@IdPrice int,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Note text = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [ORDER_DETAILS]
	(
		[OrderId],
		[ItemId],
		[Quantity],
		[IdPrice],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[Note]
	)
	VALUES
	(
		@OrderId,
		@ItemId,
		@Quantity,
		@IdPrice,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate,
		@Note
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_DETAILS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ORDER_DETAILS_Delete]
(
	@OrderDetailId int,
	@ModifiedBy nvarchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE ORDER_DETAILS
	SET Deleted = 1, ModifiedBy = @ModifiedBy

	WHERE
		[OrderDetailId] = @OrderDetailId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ORDER_DETAILS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDER_BUY_DETAILS_Update]
(
	@OrderBuyDetailId int,
	@OrderId int,
	@ItemId int,
	@Quantity decimal(18,0),
	@Price decimal,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Deleted int,
	@Note text = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE ORDER_BUY_DETAILS
	SET
		[OrderId] = case when @OrderId is null then [OrderId] else @OrderId end,
		[ItemId] = case when @ItemId is null then [ItemId] else @ItemId end,
		[Quantity] = case when @Quantity is null then [Quantity] else @Quantity end,
		[Price] = case when @Price is null then [Price] else @Price end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end,
		[Note] = case when @Note is null then [Note] else @Note end
	WHERE
		[OrderBuyDetailId] = @OrderBuyDetailId


END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ORDER_DETAILS_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[ORDER_BUY_DETAILS_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[OrderBuyDetailId],
		[OrderId],
		[ItemId],
		[Quantity],
		[Price],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[Note]
	FROM [ORDER_BUY_DETAILS]	
	 WHERE ([Deleted] = 0)
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ORDER_DETAILS_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[ORDER_BUY_DETAILS_Select]
(
	@OrderBuyDetailId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[OrderBuyDetailId],
		[OrderId],
		[ItemId],
		[Quantity],
		[Price],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[Note]
	FROM [ORDER_BUY_DETAILS]
	WHERE
		([OrderBuyDetailId] = @OrderBuyDetailId) AND	([Deleted] = 0)

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[ORDER_DETAILS_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ORDER_BUY_DETAILS_Insert]
(
	@OrderId int,
	@ItemId int,
	@Quantity decimal(18,0),
	@Price decimal,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Note text = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [ORDER_BUY_DETAILS]
	(
		[OrderId],
		[ItemId],
		[Quantity],
		[Price],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[Note]
	)
	VALUES
	(
		@OrderId,
		@ItemId,
		@Quantity,
		@Price,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate,
		@Note
	)
	SELECT SCOPE_IDENTITY()

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[ORDER_BUY_DETAILS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[ORDER_BUY_DETAILS_Delete]
(
	@OrderBuyDetailId int,
	@ModifiedBy nvarchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE ORDER_BUY_DETAILS
	SET Deleted = 1, ModifiedBy = @ModifiedBy

	WHERE
		[OrderBuyDetailId] = @OrderBuyDetailId
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ITEMS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ITEMS_Update]
(
	@ItemId int,
	@ItemName nvarchar(250),
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Deleted int,
	@TotalQuantity decimal(18,0),
	@Measurement nvarchar(150) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE ITEMS
	SET
		[ItemName] = case when @ItemName is null then [ItemName] else @ItemName end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedBy is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end,
		[TotalQuantity] = case when @TotalQuantity is null then [TotalQuantity] else @TotalQuantity end,
		[Measurement] = case when @Measurement is null then [Measurement] else @Measurement end
	WHERE
		[ItemId] = @ItemId


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ITEMS_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ITEMS_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[ItemId],
		[ItemName],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[TotalQuantity],
		[Measurement]
	FROM [ITEMS]	
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[ITEMS_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ITEMS_Select]
(
	@ItemId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[ItemId],
		[ItemName],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[TotalQuantity],
		[Measurement]
	FROM [ITEMS]
	WHERE
		([ItemId] = @ItemId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[ITEMS_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[ITEMS_Insert]
(
	@ItemName nvarchar(250),
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@TotalQuantity decimal(18,0),
	@Measurement nvarchar(150) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [ITEMS]
	(
		[ItemName],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[TotalQuantity],
		[Measurement]
	)
	VALUES
	(
		@ItemName,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate,
		@TotalQuantity,
		@Measurement
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[ITEMS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ITEMS_Delete]
(
	@ItemId int,
	@ModifiedBy nvarchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE ITEMS
	SET Deleted = 1, ModifiedBy = @ModifiedBy

	WHERE
		[ItemId] = @ItemId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[EXPENSE_Update]
(
	@ExpenseId int,
	@FromDate datetime,
	@ToDate datetime,
	@Expense decimal,
	@Location text = NULL,
	@Deleted int,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime
)	
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE EXPENSE
	SET
		[FromDate] = case when @FromDate is null then [FromDate] else @FromDate end,
		[ToDate] = case when @ToDate is null then [ToDate] else @ToDate end,
		[Expense] = case when @Expense is null then [Expense] else @Expense end,
		[Location] = case when @Location is null then [Location] else @Location end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
	WHERE
		[ExpenseId] = @ExpenseId


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[EXPENSE_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[FromDate],
		[ToDate],
		[Expense],
		[Location],
		[Deleted],
		[CreatedBy],
		[CreatedDate]
	FROM [EXPENSE]	
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[EXPENSE_Select]
(
	@ExpenseId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[FromDate],
		[ToDate],
		[Expense],
		[Location],
		[Deleted],
		[CreatedBy],
		[CreatedDate]
	FROM [EXPENSE]
	WHERE
		([ExpenseId] = @ExpenseId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[AGENT_KIND_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[EXPENSE_Insert]
(
	@FromDate datetime,
	@ToDate datetime,
	@Expense decimal,
	@Location text = NULL,
	@Deleted int,
	@CreatedBy nvarchar(250) = NULL,
	@CreateDate datetime
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [EXPENSE]
	(
		[FromDate],
		[ToDate],
		[Expense],
		[Location],
		[Deleted],
		[CreatedBy],
		[CreatedDate]
	)
	VALUES
	(
		@FromDate,
		@ToDate,
		@Expense,
		@Location,
		@Deleted,
		@CreatedBy,
		@CreateDate
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[EXPENSE_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[EXPENSE_Delete]
(
	@ExpenseId int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE EXPENSE
	SET Deleted = 1

	WHERE
		[ExpenseId] = @ExpenseId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[EMPLOYEES_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[EMPLOYEES_Update]
(
	@EmployeeId int,
	@EmployeeName nvarchar(250),
	@Salary decimal(18,0),
	@Deleted int,
	@Position nvarchar(250),
	@Birthday datetime,
	@Address text
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE EMPLOYEES
	SET
		[EmployeeName] = case when @EmployeeName is null then [EmployeeName] else @EmployeeName end,
		[Salary] = case when @Salary is null then [Salary] else @Salary end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end,
		[Position] = case when @Position is null then [Position] else @Position end,
		[Birthday] = case when @Birthday is null then [Birthday] else @Birthday end,
		[Address] = case when @Address is null then [Address] else @Address end
	WHERE
		[EmployeeId] = @EmployeeId


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[EMPLOYEES_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[EMPLOYEES_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[EmployeeId],
		[EmployeeName],
		[Deleted],
		[Salary],
		[Position],
		[Birthday],
		[Address]
	FROM [EMPLOYEES]	
	 WHERE ([Deleted] = 0)
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[EMPLOYEES_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[EMPLOYEES_Select]
(
	@EmployeeId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[EmployeeId],
		[EmployeeName],
		[Salary],
		[Deleted],
		[Position],
		[Birthday],
		[Address]
	FROM [EMPLOYEES]
	WHERE
		([EmployeeId] = @EmployeeId) AND	([Deleted] = 0)

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[EMPLOYEES_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[EMPLOYEES_Insert]
(
	@EmployeeName nvarchar(250),
	@Salary decimal(18,0),
	@Position nvarchar(250),
	@Birthday datetime,
	@Address text
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [EMPLOYEES]
	(
		[EmployeeName],
		[Salary],
		[Position],
		[Birthday],
		[Address]
	)
	VALUES
	(
		@EmployeeName,
		@Salary,
		@Position,
		@Birthday,
		@Address
	)
	SELECT SCOPE_IDENTITY()

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[EMPLOYEES_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYEES_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[EMPLOYEES_Delete]
(
	@EmployeeId int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE EMPLOYEES
	SET Deleted = 1

	WHERE
		[EmployeeId] = @EmployeeId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DEBT_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[DEBT_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[DEBT_Update]
(
	@DebtId int,
	@OldDebtValue decimal(18,0),
	@NewDebtValue decimal(18,0),
	@Payment decimal(18,0),
	@CurrentDebtValue decimal(18,0),
	@CustomerId int,
	@Deleted int,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@DebtKind int,
	@Note text = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE DEBT
	SET
		[OldDebtValue] = case when @OldDebtValue is null then [OldDebtValue] else @OldDebtValue end,
		[NewDebtValue] = case when @NewDebtValue is null then [NewDebtValue] else @NewDebtValue end,
		[Payment] = case when @Payment is null then [Payment] else @Payment end,
		[CurrentDebtValue] = case when @CurrentDebtValue is null then [CurrentDebtValue] else @CurrentDebtValue end,
		[CustomerId] = case when @CustomerId is null then [CustomerId] else @CustomerId end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[DebtKind] = case when @DebtKind is null then [DebtKind] else @DebtKind end,
		[Note] = case when @Note is null then [Note] else @Note end
	WHERE
		[DebtId] = @DebtId


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[DEBT_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[DEBT_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[DEBT_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[DebtId],
		[OldDebtValue],
		[NewDebtValue],
		[Payment],
		[CurrentDebtValue],
		[CustomerId],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[DebtKind],
		[Note]
	FROM [DEBT]	
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DEBT_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[DEBT_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[DEBT_Select]
(
	@DebtId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[DebtId],
		[OldDebtValue],
		[NewDebtValue],
		[Payment],
		[CurrentDebtValue],
		[CustomerId],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate],
		[DebtKind],
		[Note]
	FROM [DEBT]
	WHERE
		([DebtId] = @DebtId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DEBT_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[DEBT_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[DEBT_Insert]
(
	@OldDebtValue decimal(18,0),
	@NewDebtValue decimal(18,0),
	@Payment decimal(18,0),
	@CurrentDebtValue decimal(18,0),
	@CustomerId int,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@DebtKind int,
	@Note text = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [DEBT]
	(
		[OldDebtValue],
		[NewDebtValue],
		[Payment],
		[CurrentDebtValue],
		[CustomerId],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[DebtKind],
		[Note]
	)
	VALUES
	(
		@OldDebtValue,
		@NewDebtValue,
		@Payment,
		@CurrentDebtValue,
		@CustomerId,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate,
		@DebtKind,
		@Note
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[DEBT_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DEBT_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[DEBT_Delete]
(
	@DebtId int,
	@ModifiedBy nvarchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE DEBT
	SET Deleted = 1, ModifiedBy = @ModifiedBy

	WHERE
		[DebtId] = @DebtId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[BUY_PRICE_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[BUY_PRICE_Update]
(
	@BuyId int,
	@ItemId int,
	@PartnerId int,
	@BuyPrice decimal(18,0),
	@CreatedBy nvarchar(250) = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE BUY_PRICE
	SET
		[ItemId] = case when @ItemId is null then [ItemId] else @ItemId end,
		[PartnerId] = case when @PartnerId is null then [PartnerId] else @PartnerId end,
		[BuyPrice] = case when @BuyPrice is null then [BuyPrice] else @BuyPrice end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
	WHERE
		[BuyId] = @BuyId


END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[BUY_PRICE_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[BUY_PRICE_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[BuyId],
		[ItemId],
		[PartnerId],
		[BuyPrice],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate]
	FROM [BUY_PRICE]	
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[BUY_PRICE_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[BUY_PRICE_Select]
(
	@BuyId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[BuyId],
		[ItemId],
		[PartnerId],
		[BuyPrice],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate]
	FROM [BUY_PRICE]
	WHERE
		([BuyId] = @BuyId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[BUY_PRICE_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[BUY_PRICE_Insert]
(
	@ItemId int,
	@PartnerId int,
	@BuyPrice decimal(18,0),
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [BUY_PRICE]
	(
		[ItemId],
		[PartnerId],
		[BuyPrice],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate]
	)
	VALUES
	(
		@ItemId,
		@PartnerId,
		@BuyPrice,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[BUY_PRICE_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUY_PRICE_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[BUY_PRICE_Delete]
(
	@BuyId int,
	@ModifiedBy nvarchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE BUY_PRICE
	SET Deleted = 1, ModifiedBy = @ModifiedBy

	WHERE
		[BuyId] = @BuyId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[BANK_INTEREST_RATE_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENTS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[BANK_INTEREST_RATE_Update]
(
	@BankInterestRateId int,
	@BankDebtId int,
	@RateAmount decimal,
	@PayDate datetime,
	@PayAmount decimal,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE BANK_INTEREST_RATE
	SET
		[BankDebtId] = case when @BankDebtId is null then [BankDebtId] else @BankDebtId end,
		[RateAmount] = case when @RateAmount is null then [RateAmount] else @RateAmount end,
		[PayDate] = case when @PayDate is null then [PayDate] else @PayDate end,
		[PayAmount] = case when @PayAmount is null then [PayAmount] else @PayAmount end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
		
	WHERE
		[BankInterestRateId] = @BankInterestRateId


END





' 
END
GO
/****** Object:  StoredProcedure [dbo].[BANK_INTEREST_RATE_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[AGENT_KIND_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[BANK_INTEREST_RATE_Insert]
(
	@BankDebtId int,
	@RateAmount decimal,
	@PayAmount decimal,
	@PayDate datetime,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [BANK_INTEREST_RATE]
	(
		[BankDebtId],
		[RateAmount],
		[PayDate],
		[PayAmount],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate]
	)
	VALUES
	(
		@BankDebtId,
		@RateAmount,
		@PayDate,
		@PayAmount,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate
	)
	SELECT SCOPE_IDENTITY()

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[BANK_INTEREST_RATE_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[BANK_INTEREST_RATE_Delete]
(
	@BankInterestRateId int,
	@ModifiedBy nvarchar(20),
	@ModifiedDate datetime
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE BANK_INTEREST_RATE
	SET Deleted = 1, ModifiedBy = @ModifiedBy, ModifiedDate = @ModifiedDate

	WHERE
		[BankInterestRateId] = @BankInterestRateId
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENTS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[BANK_DEBTS_Update]
(
	@BankDebtId int,
	@BankName nvarchar(250) = NULL,
	@BorrowDate datetime = NULL,
	@DebtAmount decimal = NULL,
	@PaidAmount decimal = NULL,
	@MaturityDate datetime = NULL,
	@InterestRate decimal,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Deleted int
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE BANK_DEBTS
	SET
		[BankName] = case when @BankName is null then [BankName] else @BankName end,
		[BorrowDate] = case when @BorrowDate is null then [BorrowDate] else @BorrowDate end,
		[DebtAmount] = case when @DebtAmount is null then [DebtAmount] else @DebtAmount end,
		[PaidAmount] = case when @PaidAmount is null then [PaidAmount] else @PaidAmount end,
		[MaturityDate] = case when @MaturityDate is null then [MaturityDate] else @MaturityDate end,
		[InterestRate] = case when @InterestRate is null then [InterestRate] else @InterestRate end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
		
	WHERE
		[BankDebtId] = @BankDebtId


END




' 
END
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[BANK_DEBTS_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

		SELECT
		[BankDebtId]
		[BankName],
		[BorrowDate],
		[DebtAmount],
		[PaidAmount],
		[MaturityDate],
		[InterestRate],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[Deleted]
	FROM [BANK_DEBTS]	
	 WHERE ([Deleted] = 0)
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[BANK_DEBTS_Select]
(
	@BankDebtId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[BankDebtId]
		[BankName],
		[BorrowDate],
		[DebtAmount],
		[PaidAmount],
		[MaturityDate],
		[InterestRate],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[Deleted]
	FROM [BANK_DEBTS]
	WHERE
		([BankDebtId] = @BankDebtId) AND	([Deleted] = 0)

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[AGENT_KIND_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
create PROCEDURE [dbo].[BANK_DEBTS_Insert]
(
	@BankName nvarchar(250) = NULL,
	@BorrowDate datetime = NULL,
	@DebtAmount decimal = NULL,
	@PaidAmount decimal = NULL,
	@MaturityDate datetime = NULL,
	@InterestRate decimal,
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [BANK_DEBTS]
	(
		[BankName],
		[BorrowDate],
		[DebtAmount],
		[PaidAmount],
		[MaturityDate],
		[InterestRate],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate]
	)
	VALUES
	(
		@BankName,
		@BorrowDate,
		@DebtAmount,
		@PaidAmount,
		@MaturityDate,
		@InterestRate,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate
	)
	SELECT SCOPE_IDENTITY()

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[BANK_DEBTS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[BANK_DEBTS_Delete]
(
	@BankDebtId int,
	@ModifiedBy nvarchar(20),
	@ModifiedDate datetime
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE BANK_DEBTS
	SET Deleted = 1, ModifiedBy = @ModifiedBy, ModifiedDate = @ModifiedDate

	WHERE
		[BankDebtId] = @BankDebtId
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENTS_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[AGENTS_Update]
(
	@AgentId int,
	@AgentName nvarchar(250),
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@AgentKindId int,
	@Deleted int,
	@Telephone nvarchar(15) = NULL,
	@Address text = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE AGENTS
	SET
		[AgentName] = case when @AgentName is null then [AgentName] else @AgentName end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[AgentKindId] = case when @AgentKindId is null then [AgentKindId] else @AgentKindId end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end,
		[Telephone] = case when @Telephone is null then [Telephone] else @Telephone end,
		[Address] = case when @Address is null then [Address] else @Address end
	WHERE
		[AgentId] = @AgentId


END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENTS_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[AGENTS_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[AgentId],
		[AgentName],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[AgentKindId],
		[Deleted],
		[Telephone],
		[Address]
	FROM [AGENTS]	
	 WHERE ([Deleted] = 0)
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENTS_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[AGENTS_Select]
(
	@AgentId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[AgentId],
		[AgentName],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[AgentKindId],
		[Deleted],
		[Telephone]
		[Address]
	FROM [AGENTS]
	WHERE
		([AgentId] = @AgentId) AND	([Deleted] = 0)

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[AGENTS_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[AGENTS_Insert]
(
	@AgentName nvarchar(250),
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@AgentKindId int,
	@Telephone nvarchar(15) = NULL,
	@Address text = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [AGENTS]
	(
		[AgentName],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate],
		[AgentKindId],
		[Telephone],
		[Address]
	)
	VALUES
	(
		@AgentName,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate,
		@AgentKindId,
		@Telephone,
		@Address
	)
	SELECT SCOPE_IDENTITY()

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENTS_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENTS_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AGENTS_Delete]
(
	@AgentId int,
	@ModifiedBy nvarchar(20),
	@ModifiedDate datetime
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE AGENTS
	SET Deleted = 1, ModifiedBy = @ModifiedBy, ModifiedDate = @ModifiedDate

	WHERE
		[AgentId] = @AgentId
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENT_KIND_Update]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Update]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[AGENT_KIND_Update]
(
	@AgentKindId int,
	@AgentKindName nvarchar(250),
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL,
	@Deleted int
)	
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE AGENT_KIND
	SET
		[AgentKindName] = case when @AgentKindName is null then [AgentKindName] else @AgentKindName end,
		[CreatedBy] = case when @CreatedBy is null then [CreatedBy] else @CreatedBy end,
		[CreatedDate] = case when @CreatedDate is null then [CreatedDate] else @CreatedDate end,
		[ModifiedBy] = case when @ModifiedBy is null then [ModifiedBy] else @ModifiedBy end,
		[ModifiedDate] = case when @ModifiedDate is null then [ModifiedDate] else @ModifiedDate end,
		[Deleted] = case when @Deleted is null then [Deleted] else @Deleted end
	WHERE
		[AgentKindId] = @AgentKindId


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENT_KIND_SelectAll]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_SelectAll]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[AGENT_KIND_SelectAll]
AS
BEGIN

	SET NOCOUNT ON

	SELECT
		[AgentKindId],
		[AgentKindName],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate]
	FROM [AGENT_KIND]	
	 WHERE ([Deleted] = 0)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENT_KIND_Select]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
/* StoredProcedure  : dbo.[AGENT_KIND_Select]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[AGENT_KIND_Select]
(
	@AgentKindId int
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
		[AgentKindId],
		[AgentKindName],
		[CreatedBy],
		[ModifiedBy],
		[ModifiedDate]
	FROM [AGENT_KIND]
	WHERE
		([AgentKindId] = @AgentKindId) AND	([Deleted] = 0)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENT_KIND_Insert]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



/* StoredProcedure  : dbo.[AGENT_KIND_Insert]  
 Created by 		: YourName
 Date       		: 1/19/2010
 */
CREATE PROCEDURE [dbo].[AGENT_KIND_Insert]
(
	@AgentKindName nvarchar(250),
	@CreatedBy nvarchar(250) = NULL,
	@CreatedDate datetime = NULL,
	@ModifiedBy nvarchar(250) = NULL,
	@ModifiedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF

	INSERT INTO [AGENT_KIND]
	(
		[AgentKindName],
		[CreatedBy],
		[CreatedDate],
		[ModifiedBy],
		[ModifiedDate]
	)
	VALUES
	(
		@AgentKindName,
		@CreatedBy,
		@CreatedDate,
		@ModifiedBy,
		@ModifiedDate
	)
	SELECT SCOPE_IDENTITY()

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[AGENT_KIND_Delete]    Script Date: 03/31/2010 16:36:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AGENT_KIND_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AGENT_KIND_Delete]
(
	@AgentKindId int,
	@ModifiedBy nvarchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF

	UPDATE AGENT_KIND
	SET Deleted = 1, ModifiedBy = @ModifiedBy

	WHERE
		[AgentKindId] = @AgentKindId
END
' 
END
GO
/****** Object:  Default [DF_AGENT_KIND_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AGENT_KIND_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[AGENT_KIND]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AGENT_KIND_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AGENT_KIND] ADD  CONSTRAINT [DF_AGENT_KIND_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_AGENT_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AGENT_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[AGENTS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AGENT_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AGENTS] ADD  CONSTRAINT [DF_AGENT_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_BANK_DEBTS_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BANK_DEBTS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[BANK_DEBTS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BANK_DEBTS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BANK_DEBTS] ADD  CONSTRAINT [DF_BANK_DEBTS_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_BANK_INTEREST_RATE_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BANK_INTEREST_RATE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[BANK_INTEREST_RATE]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BANK_INTEREST_RATE_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BANK_INTEREST_RATE] ADD  CONSTRAINT [DF_BANK_INTEREST_RATE_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_BUY_PRICE_BuyPrice]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BUY_PRICE_BuyPrice]') AND parent_object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BUY_PRICE_BuyPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BUY_PRICE] ADD  CONSTRAINT [DF_BUY_PRICE_BuyPrice]  DEFAULT ((0)) FOR [BuyPrice]
END


End
GO
/****** Object:  Default [DF_BUY_PRICE_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BUY_PRICE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[BUY_PRICE]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BUY_PRICE_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BUY_PRICE] ADD  CONSTRAINT [DF_BUY_PRICE_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_Dept_OldDebtValue]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_OldDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_OldDebtValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_OldDebtValue]  DEFAULT ((0)) FOR [OldDebtValue]
END


End
GO
/****** Object:  Default [DF_Dept_NewDebtValue]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_NewDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_NewDebtValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_NewDebtValue]  DEFAULT ((0)) FOR [NewDebtValue]
END


End
GO
/****** Object:  Default [DF_Dept_Payment]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_Payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_Payment]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_Payment]  DEFAULT ((0)) FOR [Payment]
END


End
GO
/****** Object:  Default [DF_Dept_CurrentDebtValue]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_CurrentDebtValue]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_CurrentDebtValue]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_CurrentDebtValue]  DEFAULT ((0)) FOR [CurrentDebtValue]
END


End
GO
/****** Object:  Default [DF_Dept_Deleted]    Script Date: 03/31/2010 16:36:02 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Dept_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[DEBT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Dept_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DEBT] ADD  CONSTRAINT [DF_Dept_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_Employee_Salary]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Employee_Salary]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Employee_Salary]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EMPLOYEES] ADD  CONSTRAINT [DF_Employee_Salary]  DEFAULT ((0)) FOR [Salary]
END


End
GO
/****** Object:  Default [DF_Employee_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Employee_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYEES]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Employee_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EMPLOYEES] ADD  CONSTRAINT [DF_Employee_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_EXPENSE_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EXPENSE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXPENSE]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EXPENSE_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EXPENSE] ADD  CONSTRAINT [DF_EXPENSE_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_ITEM_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ITEM_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ITEM_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ITEMS] ADD  CONSTRAINT [DF_ITEM_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_ITEM_TotalQuantity]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ITEM_TotalQuantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ITEM_TotalQuantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ITEMS] ADD  CONSTRAINT [DF_ITEM_TotalQuantity]  DEFAULT ((0)) FOR [TotalQuantity]
END


End
GO
/****** Object:  Default [DF_OrderBuyDetail_Quantity]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderBuyDetail_Quantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderBuyDetail_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDER_BUY_DETAILS] ADD  CONSTRAINT [DF_OrderBuyDetail_Quantity]  DEFAULT ((0)) FOR [Quantity]
END


End
GO
/****** Object:  Default [DF_OrderBuyDetail_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderBuyDetail_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_BUY_DETAILS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderBuyDetail_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDER_BUY_DETAILS] ADD  CONSTRAINT [DF_OrderBuyDetail_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_OrderDetail_Quantity]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderDetail_Quantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderDetail_Quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDER_DETAILS] ADD  CONSTRAINT [DF_OrderDetail_Quantity]  DEFAULT ((0)) FOR [Quantity]
END


End
GO
/****** Object:  Default [DF_OrderDetail_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderDetail_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDER_DETAILS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderDetail_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDER_DETAILS] ADD  CONSTRAINT [DF_OrderDetail_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_ORDERS_Total]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Total]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ORDERS_Total]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDERS] ADD  CONSTRAINT [DF_ORDERS_Total]  DEFAULT ((0)) FOR [Total]
END


End
GO
/****** Object:  Default [DF_ORDERS_Pay]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Pay]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ORDERS_Pay]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDERS] ADD  CONSTRAINT [DF_ORDERS_Pay]  DEFAULT ((0)) FOR [Pay]
END


End
GO
/****** Object:  Default [DF_ORDERS_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ORDERS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDERS] ADD  CONSTRAINT [DF_ORDERS_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_ORDERS_VAT]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_ORDERS_VAT]') AND parent_object_id = OBJECT_ID(N'[dbo].[ORDERS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_ORDERS_VAT]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ORDERS] ADD  CONSTRAINT [DF_ORDERS_VAT]  DEFAULT ((0)) FOR [Vat]
END


End
GO
/****** Object:  Default [DF_Packs_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Packs_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PACKS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Packs_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PACKS] ADD  CONSTRAINT [DF_Packs_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_PARTNERS_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PARTNERS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PARTNERS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PARTNERS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PARTNERS] ADD  CONSTRAINT [DF_PARTNERS_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_PAY_SHEET_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PAY_SHEET_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PAY_SHEET]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PAY_SHEET_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PAY_SHEET] ADD  CONSTRAINT [DF_PAY_SHEET_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_PROFIT_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PROFIT_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROFIT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PROFIT_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PROFIT] ADD  CONSTRAINT [DF_PROFIT_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_PROFIT_COSTS_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PROFIT_COSTS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[PROFIT_COSTS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PROFIT_COSTS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PROFIT_COSTS] ADD  CONSTRAINT [DF_PROFIT_COSTS_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_RETURNED_ITEM_DETAILS_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_RETURNED_ITEM_DETAILS_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[RETURNED_ITEM_DETAILS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_RETURNED_ITEM_DETAILS_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[RETURNED_ITEM_DETAILS] ADD  CONSTRAINT [DF_RETURNED_ITEM_DETAILS_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_SELL_PRICE_SellPrice]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SELL_PRICE_SellPrice]') AND parent_object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SELL_PRICE_SellPrice]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SELL_PRICE] ADD  CONSTRAINT [DF_SELL_PRICE_SellPrice]  DEFAULT ((0)) FOR [SellPrice]
END


End
GO
/****** Object:  Default [DF_SELL_PRICE_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_SELL_PRICE_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[SELL_PRICE]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SELL_PRICE_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SELL_PRICE] ADD  CONSTRAINT [DF_SELL_PRICE_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
/****** Object:  Default [DF_USER_Deleted]    Script Date: 03/31/2010 16:36:03 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_USER_Deleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[USERS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_USER_Deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[USERS] ADD  CONSTRAINT [DF_USER_Deleted]  DEFAULT ((0)) FOR [Deleted]
END


End
GO
