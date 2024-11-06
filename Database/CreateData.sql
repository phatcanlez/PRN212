USE SWP391_FengShuiKoiConsulting_DB
GO
-- Insert data into Element table
INSERT INTO Element (ElementID, Mutualism) VALUES (N'Thổ',N'Hỏa');
INSERT INTO Element (ElementID, Mutualism) VALUES (N'Kim',N'Thổ');
INSERT INTO Element (ElementID, Mutualism) VALUES (N'Thủy',N'Kim');
INSERT INTO Element (ElementID, Mutualism) VALUES (N'Mộc',N'Thủy');
INSERT INTO Element (ElementID, Mutualism) VALUES (N'Hỏa',N'Mộc');
-- Insert data into Account table
INSERT INTO Account (UserID, Password, Role, Email, Status)
VALUES 
('hau', '123', 'Admin', 'hauhnse183392@fpt.edu.vn', 'Active'),
('nhan', '123', 'Member', 'nhannbse183392@fpt.edu.vn', 'Active'),
('khoa', '123', 'Member', 'khoabse183392@fpt.edu.vn', 'Active'),
('huy', '123', 'Member', 'huynbse183392@fpt.edu.vn', 'Active'),
('tin', '123', 'Member', 'tinnbse183392@fpt.edu.vn', 'Active');

-- Insert data into Member table
INSERT INTO Member (Name, Birthday, UserID)
VALUES 
(N'Huỳnh Ngọc Hậu', '1990-01-01', 'hau'),
(N'Nguyễn Bá Nhân', '1995-05-15', 'nhan'),
(N'Nguyễn Quốc Huy', '1995-05-15', 'huy'),
(N'Trương Đình Khoa', '1995-05-15', 'khoa'),
(N'Phạm Trung Tín', '2000-10-20', 'tin');

-- Insert data into Shape table
INSERT INTO Shape (ShapeID,image)
VALUES 
(N'Hình tròn','https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/hinhtron.jpg?alt=media&token=2fd87245-8ac5-4ab6-bbf0-e8bbdfcf02ef'),
(N'Hình vuông','https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Square.jpg?alt=media&token=fa0a092b-a091-4a79-be0b-11460e33e460'),
(N'Hình chữ nhật','https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/hinhchunhat.jpg?alt=media&token=07ddfbd1-a983-410a-822b-686657f9efd3'),
(N'Hình lượn sóng','https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/hinhluonsong.jpg?alt=media&token=70cbce4c-2c65-445d-9a4e-99744da6de1b'),
(N'Hình tam giác','https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/triangular_pond.jpg?alt=media&token=29d51e03-094a-4ba9-a8f4-e5a46f0e2220');


-- Insert data into PointOfShape table
INSERT INTO PointOfShape (ElementID,ShapeID,Point)
VALUES 
(N'Kim',N'Hình tròn',0.75),
(N'Kim',N'Hình vuông',1),
(N'Kim',N'Hình chữ nhật',0.25),
(N'Kim',N'Hình lượn sóng',0.5),
(N'Kim',N'Hình tam giác',0.25),
(N'Mộc',N'Hình tròn',0.25),
(N'Mộc',N'Hình vuông',0.25),
(N'Mộc',N'Hình chữ nhật',0.75),
(N'Mộc',N'Hình lượn sóng',1),
(N'Mộc',N'Hình tam giác',0.5),
(N'Thủy',N'Hình tròn',1),
(N'Thủy',N'Hình chữ nhật',0.5),
(N'Thủy',N'Hình lượn sóng',0.75),
(N'Thủy',N'Hình tam giác',0.25),
(N'Thủy',N'Hình vuông',0.25),
(N'Thổ',N'Hình tròn',0.5),
(N'Thổ',N'Hình vuông',0.75),
(N'Thổ',N'Hình chữ nhật',0.25),
(N'Thổ',N'Hình lượn sóng',0.25),
(N'Thổ',N'Hình tam giác',1),
(N'Hỏa',N'Hình tròn',0.25),
(N'Hỏa',N'Hình chữ nhật',1),
(N'Hỏa',N'Hình lượn sóng',0.25),
(N'Hỏa',N'Hình tam giác',0.75),
(N'Hỏa',N'Hình vuông',0.5);

-- Insert data into Package table
INSERT INTO Package (Rank, Duration, Description, price)
VALUES 
(N'Diamond', 30, N'Hình ảnh lớn, xuất hiện ở đầu trang, tần suất xuất hiện nhiều, phù hợp với các doanh nghiệp lớn muốn quảng bá mạnh mẽ.', 6000000),
(N'Gold', 30, N'Hình ảnh vừa, xuất hiện ở dưới gói Dimond, tần suất xuất hiện vừa, phù hợp với doanh nghiệp vừa và nhỏ muốn có sự hiện diện ổn định.', 4000000),
(N'Silver', 30, N'Hình ảnh nhỏ, chỉ xuất hiện ở trang đăng tin, tần suất xuất hiện ít, phù hợp với doanh nghiệp cá nhân hoặc startup muốn tiết kiệm chi phí.', 2000000);	
INSERT INTO LifePalace (LifePalaceID)
VALUES 
(N'Càn'),
(N'Đoài'),
(N'Cấn'),
(N'Khôn'),
(N'Ly'),
(N'Khảm'),
(N'Tốn'),
(N'Chấn');

-- Insert data into Direction table
INSERT INTO Direction (DirectionID)
VALUES 
(N'Đông Bắc'),
(N'Tây'),
(N'Tây Bắc'),
(N'Tây Nam'),
(N'Bắc'),
(N'Đông Nam'),
(N'Nam'),
(N'Đông');

-- Insert data into LifePalace_Direction table
INSERT INTO LifePalace_Direction (LifePalaceID,DirectionID,EightMansions,PointOfDirection,Description)
VALUES 
(N'Càn',N'Tây',N'Sinh khí',1,N'Đây là hướng mang lại may mắn nhất cho chủ nhà và tạo ra khí tốt.'),
(N'Càn',N'Đông Bắc',N'Thiên y',1,N'Đây là hướng tập trung vào sức khỏe, có thể giảm bớt bệnh tật và mang lại sự thịnh vượng.'),
(N'Càn',N'Tây Nam',N'Diên niên',0.75,N'Hướng mang đến sự hòa thuận, thúc đẩy sự nghiệp và gia tăng tuổi thọ.'),
(N'Càn',N'Tây Bắc',N'Phục vị',0.5,N'Hướng giúp cải thiện quan hệ gia đình và mang lại bình yên.'),
(N'Càn',N'Nam',N'Tuyệt mệnh',0.25,N'Hướng không tốt cho sự phát triển, gây ra bất hòa và đau buồn.'),
(N'Càn',N'Đông',N'Ngũ quỷ',0.25,N'Hướng gây trở ngại trong quan hệ tình cảm và có nhiều thử thách, bệnh tật.'),
(N'Càn',N'Bắc',N'Lục sát',0.25,N'Hướng dễ hao tài, tốn của và thành viên trong gia đình gặp rủi ro, tai nạn.'),
(N'Càn',N'Đông Nam',N'Họa hại',0,N'Hướng ảnh hưởng không tốt đến sức khỏe và gây rủi ro cho gia chủ.'),

(N'Đoài',N'Tây Bắc',N'Sinh khí',1,N'Đây là hướng mang lại may mắn nhất cho chủ nhà và tạo ra khí tốt.'),
(N'Đoài',N'Tây Nam',N'Thiên y',1,N'Đây là hướng tập trung vào sức khỏe, có thể giảm bớt bệnh tật và mang lại sự thịnh vượng.'),
(N'Đoài',N'Đông Bắc',N'Diên niên',0.75,N'Hướng mang đến sự hòa thuận, thúc đẩy sự nghiệp và gia tăng tuổi thọ.'),
(N'Đoài',N'Tây',N'Phục vị',0.5,N'Hướng giúp cải thiện quan hệ gia đình và mang lại bình yên.'),
(N'Đoài',N'Đông',N'Tuyệt mệnh',0.25,N'Hướng không tốt cho sự phát triển, gây ra bất hòa và đau buồn.'),
(N'Đoài',N'Nam',N'Ngũ quỷ',0.25,N'Hướng gây trở ngại trong quan hệ tình cảm và có nhiều thử thách, bệnh tật.'),
(N'Đoài',N'Đông Nam',N'Lục sát',0.25,N'Hướng dễ hao tài, tốn của và thành viên trong gia đình gặp rủi ro, tai nạn.'),
(N'Đoài',N'Bắc',N'Họa hại',0,N'Hướng ảnh hưởng không tốt đến sức khỏe và gây rủi ro cho gia chủ.'),

(N'Ly',N'Đông',N'Sinh khí',1,N'Đây là hướng mang lại may mắn nhất cho chủ nhà và tạo ra khí tốt.'),
(N'Ly',N'Đông Nam',N'Thiên y',1,N'Đây là hướng tập trung vào sức khỏe, có thể giảm bớt bệnh tật và mang lại sự thịnh vượng.'),
(N'Ly',N'Bắc',N'Diên niên',0.75,N'Hướng mang đến sự hòa thuận, thúc đẩy sự nghiệp và gia tăng tuổi thọ.'),
(N'Ly',N'Nam',N'Phục vị',0.5,N'Hướng giúp cải thiện quan hệ gia đình và mang lại bình yên.'),
(N'Ly',N'Tây Bắc',N'Tuyệt mệnh',0.25,N'Hướng không tốt cho sự phát triển, gây ra bất hòa và đau buồn.'),
(N'Ly',N'Tây',N'Ngũ quỷ',0.25,N'Hướng gây trở ngại trong quan hệ tình cảm và có nhiều thử thách, bệnh tật.'),
(N'Ly',N'Tây Nam',N'Lục sát',0.25,N'Hướng dễ hao tài, tốn của và thành viên trong gia đình gặp rủi ro, tai nạn.'),
(N'Ly',N'Đông Bắc',N'Họa hại',0,N'Hướng ảnh hưởng không tốt đến sức khỏe và gây rủi ro cho gia chủ.'),

(N'Khảm',N'Đông Nam',N'Sinh khí',1,N'Đây là hướng mang lại may mắn nhất cho chủ nhà và tạo ra khí tốt.'),
(N'Khảm',N'Đông',N'Thiên y',1,N'Đây là hướng tập trung vào sức khỏe, có thể giảm bớt bệnh tật và mang lại sự thịnh vượng.'),
(N'Khảm',N'Nam',N'Diên niên',0.75,N'Hướng mang đến sự hòa thuận, thúc đẩy sự nghiệp và gia tăng tuổi thọ.'),
(N'Khảm',N'Bắc',N'Phục vị',0.5,N'Hướng giúp cải thiện quan hệ gia đình và mang lại bình yên.'),
(N'Khảm',N'Tây Nam',N'Tuyệt mệnh',0.25,N'Hướng không tốt cho sự phát triển, gây ra bất hòa và đau buồn.'),
(N'Khảm',N'Đông Bắc',N'Ngũ quỷ',0.25,N'Hướng gây trở ngại trong quan hệ tình cảm và có nhiều thử thách, bệnh tật.'),
(N'Khảm',N'Tây Bắc',N'Lục sát',0.25,N'Hướng dễ hao tài, tốn của và thành viên trong gia đình gặp rủi ro, tai nạn.'),
(N'Khảm',N'Tây',N'Họa hại',0,N'Hướng ảnh hưởng không tốt đến sức khỏe và gây rủi ro cho gia chủ.'),

(N'Chấn',N'Nam',N'Sinh khí',1,N'Đây là hướng mang lại may mắn nhất cho chủ nhà và tạo ra khí tốt.'),
(N'Chấn',N'Bắc',N'Thiên y',1,N'Đây là hướng tập trung vào sức khỏe, có thể giảm bớt bệnh tật và mang lại sự thịnh vượng.'),
(N'Chấn',N'Đông Nam',N'Diên niên',0.75,N'Hướng mang đến sự hòa thuận, thúc đẩy sự nghiệp và gia tăng tuổi thọ.'),
(N'Chấn',N'Đông',N'Phục vị',0.5,N'Hướng giúp cải thiện quan hệ gia đình và mang lại bình yên.'),
(N'Chấn',N'Tây',N'Tuyệt mệnh',0.25,N'Hướng không tốt cho sự phát triển, gây ra bất hòa và đau buồn.'),
(N'Chấn',N'Tây Bắc',N'Ngũ quỷ',0.25,N'Hướng gây trở ngại trong quan hệ tình cảm và có nhiều thử thách, bệnh tật.'),
(N'Chấn',N'Đông Bắc',N'Lục sát',0.25,N'Hướng dễ hao tài, tốn của và thành viên trong gia đình gặp rủi ro, tai nạn.'),
(N'Chấn',N'Tây Nam',N'Họa hại',0,N'Hướng ảnh hưởng không tốt đến sức khỏe và gây rủi ro cho gia chủ.'),

(N'Tốn',N'Bắc',N'Sinh khí',1,N'Đây là hướng mang lại may mắn nhất cho chủ nhà và tạo ra khí tốt.'),
(N'Tốn',N'Nam',N'Thiên y',1,N'Đây là hướng tập trung vào sức khỏe, có thể giảm bớt bệnh tật và mang lại sự thịnh vượng.'),
(N'Tốn',N'Đông',N'Diên niên',0.75,N'Hướng mang đến sự hòa thuận, thúc đẩy sự nghiệp và gia tăng tuổi thọ.'),
(N'Tốn',N'Đông Nam',N'Phục vị',0.5,N'Hướng giúp cải thiện quan hệ gia đình và mang lại bình yên.'),
(N'Tốn',N'Đông Bắc',N'Tuyệt mệnh',0.25,N'Hướng không tốt cho sự phát triển, gây ra bất hòa và đau buồn.'),
(N'Tốn',N'Tây Nam',N'Ngũ quỷ',0.25,N'Hướng gây trở ngại trong quan hệ tình cảm và có nhiều thử thách, bệnh tật.'),
(N'Tốn',N'Tây',N'Lục sát',0.25,N'Hướng dễ hao tài, tốn của và thành viên trong gia đình gặp rủi ro, tai nạn.'),
(N'Tốn',N'Tây Bắc',N'Họa hại',0,N'Hướng ảnh hưởng không tốt đến sức khỏe và gây rủi ro cho gia chủ.'),

(N'Khôn',N'Tây Nam',N'Sinh khí',1,N'Đây là hướng mang lại may mắn nhất cho chủ nhà và tạo ra khí tốt.'),
(N'Khôn',N'Tây Bắc',N'Thiên y',1,N'Đây là hướng tập trung vào sức khỏe, có thể giảm bớt bệnh tật và mang lại sự thịnh vượng.'),
(N'Khôn',N'Tây',N'Diên niên',0.75,N'Hướng mang đến sự hòa thuận, thúc đẩy sự nghiệp và gia tăng tuổi thọ.'),
(N'Khôn',N'Đông Bắc',N'Phục vị',0.5,N'Hướng giúp cải thiện quan hệ gia đình và mang lại bình yên.'),
(N'Khôn',N'Bắc',N'Tuyệt mệnh',0.25,N'Hướng không tốt cho sự phát triển, gây ra bất hòa và đau buồn.'),
(N'Khôn',N'Đông Nam',N'Ngũ quỷ',0.25,N'Hướng gây trở ngại trong quan hệ tình cảm và có nhiều thử thách, bệnh tật.'),
(N'Khôn',N'Nam',N'Lục sát',0.25,N'Hướng dễ hao tài, tốn của và thành viên trong gia đình gặp rủi ro, tai nạn.'),
(N'Khôn',N'Đông',N'Họa hại',0,N'Hướng ảnh hưởng không tốt đến sức khỏe và gây rủi ro cho gia chủ.'),

(N'Cấn',N'Đông Bắc',N'Sinh khí',1,N'Đây là hướng mang lại may mắn nhất cho chủ nhà và tạo ra khí tốt.'),
(N'Cấn',N'Tây',N'Thiên y',1,N'Đây là hướng tập trung vào sức khỏe, có thể giảm bớt bệnh tật và mang lại sự thịnh vượng.'),
(N'Cấn',N'Tây Bắc',N'Diên niên',0.75,N'Hướng mang đến sự hòa thuận, thúc đẩy sự nghiệp và gia tăng tuổi thọ.'),
(N'Cấn',N'Tây Nam',N'Phục vị',0.5,N'Hướng giúp cải thiện quan hệ gia đình và mang lại bình yên.'),
(N'Cấn',N'Nam',N'Tuyệt mệnh',0.25,N'Hướng không tốt cho sự phát triển, gây ra bất hòa và đau buồn.'),
(N'Cấn',N'Đông',N'Ngũ quỷ',0.25,N'Hướng gây trở ngại trong quan hệ tình cảm và có nhiều thử thách, bệnh tật.'),
(N'Cấn',N'Bắc',N'Lục sát',0.25,N'Hướng dễ hao tài, tốn của và thành viên trong gia đình gặp rủi ro, tai nạn.'),
(N'Cấn',N'Đông Nam',N'Họa hại',0,N'Hướng ảnh hưởng không tốt đến sức khỏe và gây rủi ro cho gia chủ.');


-- Insert data into Koi_Variety table
INSERT INTO Koi_Variety (KoiType, Image, Element, Description) VALUES
(N'Hariwake', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Hariwake.jpg?alt=media&token=0def0060-9144-4fb2-95bb-1768f97ac892', N'Thổ', N'Hariwake là một trong những dòng cá koi vàng được yêu thích nhất với màu sắc vàng rực rỡ bao phủ trên toàn thân. Điểm nổi bật của dòng cá koi này là chúng có các đốm vàng trên lưng và cánh tay của nó. Koi hariwake được coi là biểu tượng của sự giàu có và thịnh vượng theo văn hóa Nhật Bản.'),
(N'Kikusui', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Kikusui.png?alt=media&token=5b61de72-a43d-46c8-9bea-d7c8050e79a2', N'Kim', N'Cá koi Kikusui về cơ bản là một phiên bản Doitsu của koi Hariwake, là một con koi kim loại, hai màu với màu cơ bản là trắng và hoa văn màu đỏ, cam hoặc vàng trên nền màu trắng . Kikusui cũng thường được mô tả là koi kim loại, Doitsu Kohaku koi vì nó là một con koi trắng, không vảy với hoa văn màu đỏ trên nền trắng và một lớp ánh sáng phản chiếu, hoặc bóng, trên da của cá koi.'),
(N'Goshiki', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Goshiki.png?alt=media&token=ddeb6a75-4836-4fb1-889c-6fcbc401e116', N'Hỏa', N'Cá koi Goshiki là kết quả lai tạo thành công hai giống cá koi phổ biến asagi và cá koi kohaku. Có thể nói cá koi Goshiki là một con kohaku với lớp vẩy caro màu đen ấn tượng trên lưng làm nổi bật những mảng màu đỏ (hi) vốn có của giống kohaku. Từ Goshiki có nghĩa là ngũ sắc các nhà tạo giống rất yêu thích và ấn tượng với giống cá này bởi màu sắc nó khá phong phú và đẹp mắt.'),
(N'Goromo', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Goromo.png?alt=media&token=0b9a627a-15c0-45e3-bdde-b28c0167b48e', N'Hỏa', N'Cá koi Goromo là kết quả lai tạo tình cờ giữa một con cá koi kohaku, một con Sanke hoặc một con Showa với một con cá koi Asagi. Bình thường việc lai tạo các giống koi trên với koi asagi chỉ tạo ra koi Goshiki. Chính vì đặc điểm này mà cá koi mới được đặt tên là “Goromo” – nghĩa tiếng Nhật là “được khoác áo”. Thực chất Goromo chỉ là tên rút gọn, tên đầy đủ của dòng koi Goromo này phải là Ai Goromo có nghĩa là “ được khoác áo màu xanh Indigo”.'),
(N'Soragoi', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Soragoi.png?alt=media&token=97dc3872-e1f0-4888-86e1-d416518dc8d2', N'Kim', N'Cá koi Soragoi (SOH-rog-GOY) là những con koi xám đơn màu thường có dạng lưới trên vảy của chúng được gọi là fukurin (FOO-koo-REEN).Do đó, hầu hết cá koi Soragoi đều có tiềm năng là cá koi rất lớn và thường hướng về thức ăn hơn các loại koi khác. Điều này rất tốt cho người nuôi cá koi vì nó có nghĩa là Soragoi và Chagoi, koi sẽ thường đến chào đón bạn ở đầu ao với hy vọng được cho ăn và bất kỳ con cá nào khác trong ao sẽ đi theo chúng!'),
(N'Hi Utsuri', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Hi_Utsuri.png?alt=media&token=a93b59a0-6244-4b26-8f60-e17d61ce0224', N'Hỏa', N'Koi utsuri có điểm đặc trưng là những bệt màu tạo thành vệt hoặc khoang màu lớn trên màu nền đen của chúng.Tại phần đầu của cá koi utsuri luôn có những mảng hoặc vệt màu đen. Các mảng đen trên mình koi utsuri có thể là mảng lớn, chấm nhỏ hoặc vệt uốn lượn theo chiều ngang'),
(N'Ki Utsuri', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Ki_Utsuri.png?alt=media&token=08ab8319-0528-4192-9ff9-d0b4f6339335', N'Thổ', N'Koi utsuri có điểm đặc trưng là những bệt màu tạo thành vệt hoặc khoang màu lớn trên màu nền đen của chúng.Tại phần đầu của cá koi utsuri luôn có những mảng hoặc vệt màu đen. Các mảng đen trên mình koi utsuri có thể là mảng lớn, chấm nhỏ hoặc vệt uốn lượn theo chiều ngang'),
(N'Tancho Kohaku', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Ki_Utsuri.png?alt=media&token=08ab8319-0528-4192-9ff9-d0b4f6339335', N'Kim', N'Koi tancho kohaku chính là “quốc kì sống” của đất nước Nhật Bản, chúng có thân mình và phần bụng màu trắng muốt như tuyết, tất cả các vây cũng màu trắng và chỉ có duy nhất một chấm màu đỏ lớn ở trên đầu. Đây cũng là loại cá koi Tancho được nhiều người biết đến và ao ước được sở hữu nhất.'),
(N'Kujaku', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Kujaku.png?alt=media&token=570bb692-99eb-4b8e-81ba-3577a68524f5', N'Kim', N'Cá Koi KujaKu là một trong những dòng cá Koi nổi bật bởi sở hữu bộ vảy ánh bạc nền đen pha lẫn các dãy màu đỏ vô cùng kiêu hãnh và bắt mắt. Trong vài năm gần đây, Kujaku đang ngày càng gây được sự chú ý lớn tại Việt Nam, trở thành giống cá được nhiều người yêu Koi tìm kiếm.'),
(N'Shiro Utsuri', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/shiro-utsuri.jpg?alt=media&token=7b489331-66f6-48e6-98ef-55a7ba49cecb', N'Kim', N'Cá koi utsuri được lai tạo sao cho thân mình của chúng thường chỉ có hai màu, trong đó màu đen (sumi) chiếm tỷ lệ nhỏ hơn, tạo thành các bệt đen (vết đen) trên thân cá.'),
(N'Ochiba Shigure', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/ochibaSigure.jpg?alt=media&token=3edd0243-470a-4602-bc93-1d13bd73fef4', N'Kim', N'Ochiba là giống cá Koi được lai tạo như một sự kết hợp của Chagoi và Kohaku. Trong tiếng Anh, thuật ngữ Nhật Bản dịch gần như là là mùa thu trên mặt nước. Điều này thể hiện màu sắc ánh kim loại trên mình cá Ochiba.'),
(N'Ogon', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/ogon.jpg?alt=media&token=1b828fe4-d82d-45ca-a97f-bb40934babb6', N'Thổ', N'Cá Koi Ogon được coi là một trong những giống cá Koi đẹp nhất và độc đáo nhất trên trái đất với ngoại hình đặc trưng là màu vàng óng ánh rực rỡ.'),
(N'Shusui', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/shusui.png?alt=media&token=fcf3508e-d4ed-4121-b1d3-8dc5cbcfa24f', N'Kim',N'Cá koi Shusui là một trong những giống cá chép đẹp và độc đáo nhất trong thế giới cá cảnh. Với thiết kế hai mảng vẩy lớn sậm màu trải dài từ vai xuống lưng, cá koi Shusui thực sự là một tác phẩm nghệ thuật sống đầy ấn tượng'),
(N'Taisho Sanke', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/TaishoSanke.jpg?alt=media&token=7cac13dc-a205-4d75-b2e3-318ba65996b0', N'Kim',N' Koi Taisho Sanke là một trong số 2 dòng chính được lai tạo từ cá chép hoang dã Magoi cổ xưa tại Nhật Bản.'),
(N'Kikokuryu', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Kikokuryu.jpg?alt=media&token=5fa72317-49dc-4b13-8e16-36e18ddba4d5', N'Kim', N'Cá Kikokuryu thực chất là một Kumonryu kim loại, một con cá koi với làn da bạch kim sáng bóng và vây với màu sắc Sumi sâu trong suốt. Dòng Koi  sẽ không có 2 con nào giống nhau vì chúng rất hiếm được thấy trên thị trường.'),
(N'Kin Kikokuryu', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/KinKikokuryu.jpg?alt=media&token=d57682d4-1319-4e94-b342-b8bc580df9a4', N'Thủy',N' Kin Kikokuryu kết hợp màu da cam hoặc màu vàng với các mẫu màu đen và trắng của Kikokuryu để tạo thành loại koi mới nhất trong họ cá Koi.'),
(N'Showa Sanshoku', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/showa_sanshoku.jpg?alt=media&token=d181dd06-ec05-47db-9f74-0a38c38a6c1b', N'Kim', N'Mặc dù tất cả các Showa phải sở hữu làn da đen (gọi là Sumi) được bao phủ bởi các dấu hiệu từ đỏ đến đỏ cam (Hi) và trắng (Shiroji) trên đó, có rất nhiều giống Showa khác nhau bao gồm các loại hoa văn và cách sắp xếp khác nhau.'),
(N'Kohaku', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/kohaku.jpg?alt=media&token=2852ec60-9b7b-4b86-9448-5ea5ccf872b8', N'Hỏa', N'Kohaku – dòng cá kết hợp tương phản giữa 2 màu trắng(Shiroji) và đỏ (Hi) đã tạo nên vẻ đẹp đơn giản không chỉ phổ biến nhất, đẹp nhất mà còn luôn tiềm ẩn khả năng trở thành chủng cá có giá trị cao nhất trong các dòng cá Koi.'),
(N'Asagi', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/asagi.jpg?alt=media&token=d7db3c27-ead9-422a-9277-09e0ee7ab66b',N'Thủy', N'Asagi chính là giống sản sinh ra Nishikigoi, chúng bắt nguồn từ loài cá chép đen thường sinh sống ở những vùng sông hoặc suối, những chú cá chép đen có sự tiến hóa vượt bậc và được người dân Nhật chọn lựa những chú cá có màu sắc như Trắng, Xanh dương và màu đỏ và giữ lại trong hồ.'),
(N'Kumonryu', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/kumonryu.png?alt=media&token=87737e14-d431-4169-b570-3428e2a8eb10', N'Kim', N'Kumonryu là koi Doitsu có hoa văn màu đen như mực nổi lên như những đám mây sấm đen cuồn cuộn trên nền tuyết trắng. Một con Koi Ben Kumonryu được đánh giá là đẹp khi có sự tương xứng và cân bằng giữa các màu đỏ, đen và trắng trên thân của nó.'),
(N'Beni Kumonryu', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Beni_Kumonryu.jpg?alt=media&token=de20399f-5096-4b07-9de0-ff67e850ab0f', N'Hỏa', N'Koi Beni Kumonryu là một biến thể hiếm hoi của Kumonryu, chúng thường có ba màu là đỏ, đen và trắng.'),
(N'Ginrin Chagoi', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/GinrinChagoi.jpg?alt=media&token=285e08f0-138c-43b9-a0cb-cc7e726b913e', N'Thổ', N'Ginrin Chagoi luôn chiếm được sự yêu thích từ người chơi cá koi. Chagoi biểu tượng cho sự mạnh mẽ, dũng cảm, sẵn sàng đương đầu với thử thách để đạt được thành công.' ),
(N'Matsuba', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/matsubaKOI.png?alt=media&token=2ea65ebd-52f5-420e-8b00-96351367e72d', N'Kim', N'Koi Matsuba là những con cá đơn sắc. Giống cá này thường có 3 màu chủ yếu là màu trắng bạc, màu vàng hoặc màu đỏ cam. Matsuba là cá koi màu kim loại với hoạ tiết lưới màu đen. Cơ thể của cá koi Matsuba có một màu với vảy hình nón rỗng'),
(N'Gin Rin Yamato Nishiki', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/GinRinYamatoNishiKi.jpg?alt=media&token=d452d1c9-15ec-4dcf-8217-a2927639a9b5', N'Hỏa', N'Gin Rin Yamato nishiki koi là loài cá được lai tạo khoảng thời gian sau này của giống koi sanke. Có thể nói cá koi yamato nishiki giúp vẻ đẹp màu sắc Gin Rin tiến đến một tầm mới hơn khi phủ lên mình cá một lớp ánh kim loại lấp lánh.'),
(N'Ushutimono', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Ushutimono.jpg?alt=media&token=c200e681-db87-4dc2-b7fc-fdbbeb071944', N'Mộc', N'Ushutimono có màu xanh chiếm phần lớn cơ thể, với các vảy màu trắng xen kẽ. Hoa văn của vảy tạo ra sự tương phản rõ rệt giữa màu xanh và trắng, với màu xanh nổi bật hơn, bao phủ phần lớn thân cá. Các vây và đuôi cũng có màu xanh nhẹ. Cá này có thể là một biến thể của dòng Koi có sự pha trộn mạnh mẽ giữa hai màu xanh và trắng.'),
(N'Midorigoi', N'https://firebasestorage.googleapis.com/v0/b/swp391-koifengshuiconsult.appspot.com/o/Midorigoi.jpg?alt=media&token=2c919b0f-0683-4fbe-8a85-d094dc490d0d', N'Mộc', N'Midorigoi có màu xanh lục nhạt phủ toàn thân, với các vảy đều đặn và bóng loáng. Màu sắc chủ đạo là xanh lục, bao gồm cả vây và đuôi. Cá này có thể thuộc dòng Koi Ogon, đặc trưng bởi màu đơn sắc và sự bóng bẩy của lớp vảy.');

-- Insert data into Color table
INSERT INTO Color (ColorID) VALUES
(N'Vàng'),
(N'Trắng'),
(N'Đỏ'),
(N'Đen'),
(N'Cam'),
(N'Bạc'),
(N'Nâu'),
(N'Xanh lục');
-- Insert data into Element_Color table
INSERT INTO Element_Color (ElementID,ColorID,ColorPoint) VALUES
(N'Kim',N'Vàng',1),
(N'Kim',N'Trắng',0.75),
(N'Kim',N'Đỏ',0.25),
(N'Kim',N'Xanh lục',0.25),
(N'Kim',N'Đen',0.5),
(N'Kim',N'Cam',0.25),
(N'Kim',N'Bạc',0.75),
(N'Kim',N'Nâu',1),
(N'Hỏa',N'Xanh lục',1),
(N'Hỏa',N'Vàng',0.5),
(N'Hỏa',N'Trắng',0.25),
(N'Hỏa',N'Đỏ',0.75),
(N'Hỏa',N'Đen',0.25),
(N'Hỏa',N'Cam',0.75),
(N'Hỏa',N'Bạc',0.25),
(N'Hỏa',N'Nâu',0.5),
(N'Mộc',N'Vàng',0.25),
(N'Mộc',N'Trắng',0.25),
(N'Mộc',N'Xanh lục',0.75),
(N'Mộc',N'Đỏ',0.5),
(N'Mộc',N'Đen',1),
(N'Mộc',N'Cam',0.5),
(N'Mộc',N'Bạc',0.25),
(N'Mộc',N'Nâu',0.25),
(N'Thủy',N'Vàng',0.25),
(N'Thủy',N'Trắng',1),
(N'Thủy',N'Xanh lục',0.5),
(N'Thủy',N'Đỏ',0.25),
(N'Thủy',N'Đen',0.75),
(N'Thủy',N'Cam',0.25),
(N'Thủy',N'Bạc',1),
(N'Thủy',N'Nâu',0.25),
(N'Thổ',N'Vàng',0.75),
(N'Thổ',N'Trắng',0.5),
(N'Thổ',N'Xanh lục',0.25),
(N'Thổ',N'Đỏ',1),
(N'Thổ',N'Đen',0.25),
(N'Thổ',N'Cam',0.75),
(N'Thổ',N'Bạc',0.5),
(N'Thổ',N'Nâu',0.75);

-- Insert data into Type_Color table
INSERT INTO Type_Color (KoiType, ColorID, Percentage) VALUES
(N'Hariwake', N'Vàng', 0.6),
(N'Hariwake', N'Trắng', 0.4),
(N'Kikusui', N'Trắng', 0.7),
(N'Kikusui', N'Đỏ', 0.3),
(N'Goshiki', N'Đỏ', 0.7),
(N'Goshiki', N'Đen', 0.2),
(N'Goshiki', N'Trắng', 0.1),
(N'Goromo', N'Đỏ', 0.6),
(N'Goromo', N'Trắng', 0.4),
(N'Soragoi', N'Trắng', 1),
(N'Hi Utsuri', N'Cam', 0.7),
(N'Hi Utsuri', N'Đen', 0.3),
(N'Ki Utsuri', N'Vàng', 0.7),
(N'Ki Utsuri', N'Đen', 0.3),
(N'Tancho Kohaku', N'Trắng', 0.9),
(N'Tancho Kohaku', N'Đỏ', 0.1),
(N'Kujaku', N'Bạc', 0.6),
(N'Kujaku', N'Đen', 0.2),
(N'Kujaku', N'Đỏ', 0.2),
(N'Shiro Utsuri', N'Trắng', 0.7),
(N'Shiro Utsuri', N'Đen', 0.3),
(N'Ochiba Shigure', N'Trắng', 0.7),
(N'Ochiba Shigure', N'Cam', 0.3),
(N'Ogon', N'Vàng', 1),
(N'Shusui', N'Trắng', 0.6),
(N'Shusui', N'Đen', 0.4),
(N'Taisho Sanke', N'Trắng', 0.7),
(N'Taisho Sanke', N'Đen', 0.15),
(N'Taisho Sanke', N'Đỏ', 0.15),
(N'Kikokuryu', N'Trắng', 0.8),
(N'Kikokuryu', N'Đen', 0.2),
(N'Kin Kikokuryu', N'Đen', 0.6),
(N'Kin Kikokuryu', N'Vàng', 0.3),
(N'Kin Kikokuryu', N'Trắng', 0.1),
(N'Showa Sanshoku', N'Trắng', 0.7),
(N'Showa Sanshoku', N'Đỏ', 0.2),
(N'Showa Sanshoku', N'Đen', 0.1),
(N'Kohaku', N'Đỏ', 0.6),
(N'Kohaku', N'Trắng', 0.4),
(N'Asagi', N'Đen', 0.5),
(N'Asagi', N'Đỏ', 0.1),
(N'Asagi', N'Trắng', 0.4),
(N'Kumonryu', N'Trắng', 0.6),
(N'Kumonryu', N'Đen', 0.4),
(N'Beni Kumonryu', N'Đỏ', 0.6),
(N'Beni Kumonryu', N'Trắng', 0.3),
(N'Beni Kumonryu', N'Đen', 0.1),
(N'Ginrin Chagoi', N'Vàng', 0.8),
(N'Ginrin Chagoi', N'Nâu', 0.2),
(N'Matsuba', N'Trắng', 0.6),
(N'Matsuba', N'Đen', 0.4),
(N'Gin Rin Yamato Nishiki', N'Trắng', 0.25),
(N'Gin Rin Yamato Nishiki', N'Cam', 0.7),
(N'Gin Rin Yamato Nishiki', N'Đen', 0.05),
(N'Ushutimono', N'Trắng', 0.3), 
(N'Ushutimono', N'Xanh lục', 0.7),
(N'Midorigoi', N'Xanh lục', 1);

-- Insert data into Quantity table
INSERT INTO QuantityOfFish (ElementID, Description) VALUES
(N'Thủy', N'Phù hợp nuôi số lượng cá có hàng đơn vị là 1 hoặc 6. VD: 1 con, 11 con, 6 con, 26 con,...'),
(N'Kim', N'Phù hợp nuôi số lượng cá có hàng đơn vị là 4 hoặc 9. VD: 4 con, 14 con, 9 con, 29 con,...'),
(N'Mộc', N'Phù hợp nuôi số lượng cá có hàng đơn vị là 3 hoặc 8. VD: 3 con, 13 con, 8 con, 28 con,...'),
(N'Hỏa', N'Phù hợp nuôi số lượng cá có hàng đơn vị là 2 hoặc 7. VD: 2 con, 12 con, 7 con, 27 con,...'),
(N'Thổ', N'Phù hợp nuôi số lượng cá có hàng đơn vị là 5 hoặc 0. VD: 10 con, 5 con, 15 con,...');


