CREATE TABLE Users (
    UserID INT PRIMARY KEY identity(1,1),
    ProfileImage VARBINARY(MAX),
    Username VARCHAR(50),
    Phone VARCHAR(15),
    Email VARCHAR(100),
    Password VARCHAR(100),
    Role VARCHAR(50),   -- Column for role (e.g., student, teacher, etc.)
    Address VARCHAR(255) -- Column for address
);
