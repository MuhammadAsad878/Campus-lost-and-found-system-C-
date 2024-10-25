CREATE TABLE Claims (
    ClaimID INT PRIMARY KEY,
    ItemID INT,
    UserID INT,
    ClaimDate DATETIME,
    Status VARCHAR(20),
    FOREIGN KEY (ItemID) REFERENCES Items(ItemID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
