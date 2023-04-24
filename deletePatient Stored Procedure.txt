CREATE or alter PROCEDURE deletePatient
    @PersonalDetailsID INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    -- delete from patient records
    BEGIN TRY
    delete from Patient where Patient.pdID = @PersonalDetailsID

    -- delete from personalDetailsId records
    delete from PersonalDetails where PersonalDetails.pdID = @PersonalDetailsID
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN;
    END CATCH;
    COMMIT TRANSACTION;
END