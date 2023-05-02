CREATE or alter PROCEDURE registerPatient
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Gender NVARCHAR(50),
    @Street NVARCHAR(50),
    @City NVARCHAR(50),
    @State NVARCHAR(50),
    @ZipCode NVARCHAR(50),
    @Country NVARCHAR(50),
    @PhoneNumber NCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    -- Insert new personal details record
    DECLARE @personalDetailsId INT;
    BEGIN TRY
    INSERT INTO PersonalDetails(firstName,lastName,dateOfBirth,gender,streetAddress,city,state,zipCode,country,phoneNumber) 
    VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Street, @City, @State, @ZipCode, @Country, @PhoneNumber);

    -- Get the newly added personalDetails primary key
    SET @personalDetailsId = SCOPE_IDENTITY();

    -- Insert the personalDetailsId into the patients table
    INSERT INTO Patient(pdID) 
    VALUES (@personalDetailsId);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN;
    END CATCH;
    COMMIT TRANSACTION;
END