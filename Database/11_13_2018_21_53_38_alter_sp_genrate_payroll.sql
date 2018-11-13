
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- =============================================

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spSaveGeneratedPayroll] 
--ADDITIONALS
	@ot float,@allowance float,
	@incentive float,@bonus float,
	@other1v float,@other2v float,
	@other3v float,@other1 varchar(50),
	@other2 varchar(50),@other3 varchar(50),
--DEDUCTIONS
	@sss float,@pagibig float,
	@philhealth float, @tax float,
	@sssloan float, @pagibigloan float,
	@proviloan float, @absent float,
	@lates float, @provifund float,
	@smcard float, @arhealthcard float,
	@others float, @remarks varchar(max),
	@dateFrom date,@dateTo date,
---EMPLOYEE DETAILS
	@employeeName varchar(max),@totaladd float,
	@totaldeduc float, @takehomepay float
AS
BEGIN
	Declare @additionalID INT,
			@deductionID INT,
			@payrollDetailsID INT,
			@employeeID INT

	SET NOCOUNT ON;

	--INSERT ADDITIONALS
	INSERT INTO Additionals(OT,Allowance,Incentives,Bonus,Other1,Other1V,Other2,Other2V,Other3,Other3V)
	SELECT @ot,@allowance,@incentive,@bonus,@other1,@other1v,@other2,@other2v,@other3,@other3v;
	SET @additionalID = SCOPE_IDENTITY();

	---INSERT DEDUCTIONS
	INSERT INTO Deductions(SSS,PagIbig,PhilHealth,Tax,SSSLoan,PagIbigLoan,ProviLoan,Absents,Lates,ProvidentFund,SMCard,ArHealthCard,Other)
	SELECT @sss,@pagibig,@philhealth,@tax,@sssloan,@pagibigloan,@proviloan,@absent,@lates,@provifund,@smcard,@arhealthcard,@others;
	SET @deductionID = SCOPE_IDENTITY();

	--- INSERT DETAILS
	SELECT @employeeID = (SELECT ID FROM Employee WHERE EmployeeName = @employeeName);
	INSERT INTO PayrollDetails(EmployeeID,AdditionalID,DeductionID,DateFrom,DateTo,TotalAdditional,TotalDeduction,TotalTakeHomePay)
	SELECT @employeeID,@additionalID,@deductionID,@dateFrom,@dateTo,@totaladd,@totaldeduc,@takehomepay;
	SET @payrollDetailsID = SCOPE_IDENTITY();

	INSERT INTO Remarks(PayrollDetailsID,Remarks)
	SELECT @payrollDetailsID,@remarks

	
END
