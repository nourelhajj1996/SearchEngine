USE SearchEngineDB
GO

CREATE TABLE Terms (
	id INT IDENTITY(1,1) NOT NULL,
    value NVARCHAR(200) NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE Documents(
	id INT IDENTITY(1,1) NOT NULL,
    path NVARCHAR(500) NOT NULL,
    indexTime datetime,
    PRIMARY KEY(id)
);

CREATE TABLE [Contains](
	termId INT NOT NULL,
    documentId INT NOT NULL,
    positionIndex BIGINT NOT NULL,
    
    FOREIGN KEY (termId) 
        REFERENCES Terms(id)
        ON DELETE CASCADE,
        
	FOREIGN KEY (documentId) 
        REFERENCES Documents(id)
        ON DELETE CASCADE
);
