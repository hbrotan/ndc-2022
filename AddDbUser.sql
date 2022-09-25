CREATE USER [ndc-demo] FROM EXTERNAL PROVIDER;
ALTER ROLE db_datareader ADD MEMBER [ndc-demo];
ALTER ROLE db_datawriter ADD MEMBER [ndc-demo];