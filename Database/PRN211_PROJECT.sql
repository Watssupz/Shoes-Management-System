USE master
ALTER DATABASE [PRN211_Project] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

ALTER DATABASE [PRN211_Project] SET MULTI_USER;

IF exists (SELECT NAME FROM master.dbo.sysdatabases WHERE NAME = 'PRN211_Project')
BEGIN
	DROP DATABASE PRN211_Project
END

GO
	CREATE DATABASE PRN211_Project

GO
	USE PRN211_Project

GO
-- ==================== Accounts ====================
	CREATE TABLE [Accounts](
		[username] VARCHAR(255) NOT NULL PRIMARY KEY,
		[password] VARCHAR(255) NOT NULL,
        [email] VARCHAR(255) NOT NULL,
		[fullname] NVARCHAR(255) NOT NULL,
		[address] NVARCHAR(255) NOT NULL,
		--[phonenumber] VARCHAR(20) NOT NULL,
		[role] BIT NOT NULL,
	)
-- ==================== Orders ====================
	CREATE TABLE [Orders](
		[OrderID] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[username] VARCHAR(255) NOT NULL,
		[OrderDate] DATETIME NOT NULL,
		[Location] NVARCHAR(255) NOT NULL,
		--[PhoneNumber] VARCHAR(255) NOT NULL,
		[Status] INT NOT NULL,
		[TotalBill] MONEY
	)

-- ==================== Products ====================
	CREATE TABLE [Products](
		[ProductID] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[CategoryID] INT,
		[ProductName] VARCHAR(255),
		[Quantity] INT,
		[UnitPrice] MONEY,
		[Picture] VARCHAR(255),
		[Description] NVARCHAR(1000)
	)

-- ==================== Categories ====================
	CREATE TABLE [Categories](
		[CategoryID] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[CategoryName] VARCHAR(255) NOT NULL,
	)
	
-- ==================== Connect table ====================
	-- Accounts & Orders
	ALTER TABLE [Orders]
	ADD FOREIGN KEY ([username]) REFERENCES [Accounts](username)

	-- Orders & Products
	CREATE TABLE [OrderDetails](
		[OrderID] INT FOREIGN KEY REFERENCES [Orders](OrderID),
		[ProductID] INT FOREIGN KEY REFERENCES [Products](ProductID),
		[Quantity] INT not null,
		PRIMARY KEY ([OrderID],[ProductID])
	)

	-- Categories & Products
	ALTER TABLE [Products]
	ADD FOREIGN KEY ([CategoryID]) REFERENCES [Categories](CategoryID)

	-- Products & Accounts
	CREATE TABLE [Cart](
		[username] VARCHAR(255) FOREIGN KEY REFERENCES [Accounts](username) ON DELETE CASCADE,
		[ProductID] INT FOREIGN KEY REFERENCES [Products](ProductID) ON DELETE CASCADE NOT NULL,
		[Quantity] INT NOT NULL,
		PRIMARY KEY ([username],[ProductID])
	)


-- ==================== Insert information into Accounts ====================
	INSERT INTO [Accounts]([username] , [password] , [email] , [fullname] , [address] , [role])
		VALUES ('duc' , 'abc' , 'nguyennduongg039@gmail.com' , 'TanDuc' , 'Hanoi'  , 0)
	INSERT INTO [Accounts]([username] , [password] , [email] , [fullname] , [address] , [role])
		VALUES ('duong' , 'a123' , 'nguyennduongg039@gmail.com' , 'ManhDuong' , 'Hanoi' , 1)
	INSERT INTO [Accounts]([username] , [password] , [email] , [fullname] , [address] , [role])
		VALUES ('khanh' , '123456' , 'nguyennduongg039@gmail.com' , 'CongKhanh' , 'Hanoi' , 0)
	INSERT INTO [Accounts]([username] , [password] , [email] , [fullname] , [address] , [role])
		VALUES ('thanh' , '1234' , 'nguyennduongg039@gmail.com' , 'KhacThanh' , 'Hanoi' , 1)

-- ==================== Insert information into Categories ====================
	INSERT INTO [Categories](CategoryName)
		VALUES ('Nike')
	INSERT INTO [Categories](CategoryName)
		VALUES ('Adidas')
	INSERT INTO [Categories](CategoryName)
		VALUES ('Vans')
	INSERT INTO [Categories](CategoryName)
		VALUES ('Converse')

-- ==================== Insert information into Products ====================
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])
		VALUES ( 1 ,  'Jordan Air 4 Retro Doernbecher' , 100 ,  2000 , 'https://i.ibb.co/64R7ptp/JD4-Retro-1.png' , 'The shoe features a black patent leather upper with metallic gold accents, a translucent outsole, and a unique graphic design on the tongue and heel.');
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])
		VALUES ( 1 ,  'Jordan 1 High' , 100 , 2500 , 'https://i.ibb.co/JdKQCwS/JD1.png' , 'The Air Jordan 1 High remakes the classic sneaker, giving you a fresh look with a familiar feel. Premium materials with new colours and textures give modern expression to an all-time favourite. Leather offers durability and structure.');
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])
		VALUES ( 1 ,  'Jordan 1 x Dior' , 100 , 3000 , 'https://i.ibb.co/7Nqhfc1/JD-Dior.png', 'The Dior x Air Jordan 1 High sneakers are the first collaboration between the luxury powerhouse and sneaker giant. Crafted from wolf grey and sail white leather, these Air Jordan 1 High sneakers take on the iconic high-top silhouette, and update it by way of a grey Dior monogram swoosh logo.');
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])
		VALUES ( 1 ,  'Jordan Air 4 Retro Navy' , 100 , 5000 , 'https://i.ibb.co/1GW8GtN/JD4-Retro-Navy.png', 'The Jordan 4 Retro Midnight Navy comes in a White, Midnight Blue and Light Smoky Grey color scheme. The upper of this pair is made of white leather, revealing black support wings. The black heel tab has an embossed Jumpman logo and navy blue molded eyelets.');

	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])
		VALUES ( 3 ,  'Vans OG' , 100 , 1500 , 'https://i.ibb.co/kGFJbYJ/Vans-OG.png' , 'Vans OG, the epitome of timeless cool, rock the streets with their classic, authentic design. A symbol of skate culture, these kicks effortlessly blend style and substance. With their iconic waffle outsole and simple, yet versatile canvas or suede uppers, Vans OG sneakers are the choice for those who know how to roll with effortless, laid-back swagger.');
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])
		VALUES ( 3 ,  'Vans Authentic' , 100 , 1000 , 'https://i.ibb.co/ZTkqc94/Vans-Authen.png', 'Vans Authentic: The embodiment of timeless authenticity and effortless style. Skate culture''s enduring icon, these sneakers are your go-to for classic, laid-back cool. Whether on a board or strolling the streets, they''re a symbol of self-expression and genuine individuality.' );
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])		
		VALUES ( 3 ,  'Vans Black Skull' , 100 , 2700 , 'https://i.ibb.co/jfRm9tR/Vans-Black-Skull.png' , 'Vans Black Skull: Where skate culture meets edgy style. These kicks aren''t just shoes; they''re a statement. With a sleek black canvas as your canvas, the iconic Vans silhouette gets a rebellious upgrade with the skull and crossbones. Whether you''re grinding at the park or making a bold fashion statement, Vans Black Skull brings a touch of punk attitude to your every step.');
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])
		VALUES ( 3 ,  'Vans Old Skool' , 100 , 3000 , 'https://i.ibb.co/0CNVZyB/Vans-Old-Skool.png' , 'Vans Old Skool: The OG rebels of the sneaker world. Classic, yet always fresh, with their iconic side stripe and durable canvas, they''re the ultimate style for those who march to their own beat. From skate parks to city streets, Vans Old Skool kicks it old-school with an effortless coolness that never goes out of style.');

	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])		
		VALUES ( 4 , 'Converse Chuck 70 Amarillo' , 100 , 6000 , 'https://i.ibb.co/vvcfqS7/Converse-Chukck70-Amarillo.png', 'MY STORY. MY HUSTLE. In celebration of International Women''s Day, Converse updated the best ever Chuck 70 with allover, color-popped graphics. The "My Story" print serves as a reminder to use your voice and stay empowered. An elevated style icon, it features more cushioning to keep you looking—and feeling—good all day.')
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])		
		VALUES ( 4 , 'Converse Chuck Taylor All Star Beige' , 100 , 7000 , 'https://i.ibb.co/MMy1Kgj/Converse-Chuck-Taylor-All-Star-Beige.png', 'Elevate your everyday look with a fresh pair of platforms. Made with a durable cotton canvas upper, these easy-to-pair shoes lift you up with zero sacrifices in style. Finished with spliced rubber details for an unexpected but unmistakable look, they''re a must-have for All Stars everywhere.')
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])		
		VALUES ( 4 , 'Converse ERX260 White Black Dolphin ' , 100 , 8000 , 'https://i.ibb.co/NmtZ2Mm/Converse-ERX260-White-Black-Dolphin.png', 'Sports shoes with a modern and innovative design from Converse''s ERX 260 product line. The color combination of white, black and light gray creates a unique and interesting color combination appearance. Shoes have a strong and modern sporty style.')
	INSERT INTO [Products]([CategoryID] , [ProductName] , [Quantity] , [UnitPrice] , [Picture] , [Description])		
		VALUES ( 4 , 'Converse Chuck University Red ' , 100 , 9000 , 'https://i.ibb.co/fxfW6f7/Converse-Chuck-University-Red.png', 'Born on the basketball court, redesigned for a fresh makeover—the Converse Chuck Taylor Alt Star reinterprets the classic style in canvas. Details like the exposed foam and exaggerated toe box keep your style stylish. Additionally, the text written on the midsole reads "Far from Chuck", taking you to new frontiers to continue exploring.')























