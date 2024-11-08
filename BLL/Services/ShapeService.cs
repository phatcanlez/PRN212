﻿using DAL.Entities;
using DAL.Repository;

namespace BLL.Services
{
    public class ShapeService
    {
        ShapeRepository shapeRepository = new();
        public List<Shape> GetShapes()
        {
            Console.WriteLine($@"Nữ nhân viên ngân hàng lừa đảo 6 tỷ đồng nướng vào tiền ảo và trả nợ\r\nThư\u0301 Sa\u0301u, 08/11/2024 11:17  | Hoàng Quân\r\n\r\n | \r\n(CAO) Quá trình làm việc tại một chi nhánh ngân hàng ở Đà Nẵng, Cù Thị Hoài Thanh (31 tuổi) vay của 2 người 6 tỷ đồng. Thanh chiếm đoạt để trả nợ và nướng vào tiền ảo nhưng bị thua sạch.\r\n\r\n“Hotgirl” lừa 47 tỷ đồng bằng chiêu đáo hạn ngân hàng\r\nBắt 'kiều nữ' lừa đảo qua vay tiền để đáo hạn cho công ty gốm sứ\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng\r\nNgày 08/11, Cơ quan CSĐT (Phòng Cảnh sát hình sự) Công an TP.Đà Nẵng ra thông báo tìm bị hại trong vụ án “Lừa đảo chiếm đoạt tài sản” do Cù Thị Hoài Thanh (SN 1993, ngụ P.Hòa Khánh Bắc, Q.Liên Chiểu, Đà Nẵng) – nhân viên ngân hàng tại Đà Nẵng thực hiện.\r\n\r\nADVERTISEMENT\r\n\r\n\r\n\r\nBị can Cù Thị Hoài Thanh.\r\nTheo điều tra, Cù Thị Hoài Thanh là nhân viên của một ngân hàng chi nhánh Sông Hàn (địa chỉ tại P.Hòa Thuận Đông, Q.Hải Châu, Đà Nẵng). Trong quá trình làm việc, Thanh quen biết với bà Nguyễn Thị D.K. (ngụ Đà Nẵng).\r\n\r\nVới lý do để làm thủ tục đáo hạn ngân hàng cho khách hàng, từ tháng 9/2022 đến cuối năm 2023, Thanh nhiều lần mượn tiền bà K. Thời gian đầu, Thanh trả tiền lãi và tiền gốc đầy đủ cho bà K.\r\n\r\nADVERTISEMENT\r\n\r\n\r\nTuy nhiên sau đó, Thanh cần tiền để trả nợ cá nhân và đầu tư tiền ảo nên Thanh nói dối là cần tiền để đáo hạn ngân hàng khiến cho bà K tin tưởng. Từ ngày 07/11/2023, Thanh mượn của bà K. 3,35 tỷ đồng và dùng để trả nợ, “nướng” vào tiền ảo. Tuy nhiên Thanh bị thua lỗ hết.\r\n\r\nNgoài ra, từ ngày 29/5/2023 đến ngày 24/7/2023, Thanh nói dối là cần tiền để đáo hạn ngân hàng và mượn của ông Nguyễn Văn N. (ngụ TP.Đà Nẵng) 2,5 tỷ đồng.
Thanh cũng chiếm đoạt số tiền này để trả nợ, nướng vào tiền ảo.\r\n\r\n\r\nCơ quan CSĐT Công an TP.Đà Nẵng làm việc với bị can Cù Thị Hoài Thanh (áo sọc trắng).\r\nTừ đơn tố giác của các bị hại, Cơ quan CSĐT Công an TP.Đà Nẵng điều tra làm rõ, đến ngày 23/07/2024 khởi tố vụ án, khởi tố bị can và bắt tạm giam đối với Cù Thị Hoài Thanh.\r\n\r\nĐể phục vụ công tác điều tra mở rộng, CQĐT thông báo cho ai là bị hại của Cù Thị Hoài Thanh thì liên hệ đến Phòng Cảnh sát hình sự (số 47 Lý Tự Trọng, P.Thạch Thang, Q.Hải Châu, TP.Đà Nẵng) hoặc qua Điều tra viên Nguyễn Văn Dũng, điện thoại 0915.707.677 để trình báo, cung cấp thông tin và được hướng dẫn giải quyết.\r\n\r\nHoàng Quân\r\nADVERTISEMENT\r\n\r\n\r\nTừ Khóa Cù Thị Hoài Thanh lừa đảo nhân viên ngân hàng lừa đảo 6 tỷ lừa đảo nướng vào tiền ảo CATP.Đà Nẵng bắt kẻ lừa đảo cảnh giác tiền đáo hạn ngân hàng\r\nPlay Video\r\nXử lý thanh niên vi phạm nồng độ cồn ‘kịch khung’, còn tát vào mặt CSGT\r\nBình luận (0)\r\nNội dung bình luận\r\nTIN KHÁC\r\nPhá đường dây sản xuất dầu gió giả quy mô lớn Phá đường dây sản xuất dầu gió giả quy mô lớn Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh \r\nPhá đường dây buôn pháo lậu số lượng lớn từ Bình Phước ra Nghệ An (06/11)\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn (06/11)\r\nCông ty Xuyên Việt Oil gây thất thoát hàng ngàn tỷ đồng (kỳ cuối) (06/11)\r\nNhững cọc tiền làm mờ mắt cựu Chủ tịch HĐTV NXB Giáo dục (06/11)\r\nChủ công ty sản xuất, buôn bán 271 tấn phân bón giả, gây thiệt hại lớn cho nông dân (06/11)\r\nTPHCM: Tăng cường quản lý, kiểm tra nguồn gốc sản phẩm, hàng hóa tại chợ (05/11)\r\nTìm bị hại của “nữ quái” Lê Thị Thư lừa đảo nhiều tỷ đồng (05/11)\r\nTPHCM: Bắt giam chủ nhà thuốc Mỹ Châu và ca sĩ Quốc Kháng liên quan (05/11)\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng (05/11)\r\nNhức nhối nạn buôn lậu pháo nổ trên tuyến biên giới Tây Nam (05/11)");
            Console.WriteLine($@"Nữ nhân viên ngân hàng lừa đảo 6 tỷ đồng nướng vào tiền ảo và trả nợ\r\nThư\u0301 Sa\u0301u, 08/11/2024 11:17  | Hoàng Quân\r\n\r\n | \r\n(CAO) Quá trình làm việc tại một chi nhánh ngân hàng ở Đà Nẵng, Cù Thị Hoài Thanh (31 tuổi) vay của 2 người 6 tỷ đồng. Thanh chiếm đoạt để trả nợ và nướng vào tiền ảo nhưng bị thua sạch.\r\n\r\n“Hotgirl” lừa 47 tỷ đồng bằng chiêu đáo hạn ngân hàng\r\nBắt 'kiều nữ' lừa đảo qua vay tiền để đáo hạn cho công ty gốm sứ\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng\r\nNgày 08/11, Cơ quan CSĐT (Phòng Cảnh sát hình sự) Công an TP.Đà Nẵng ra thông báo tìm bị hại trong vụ án “Lừa đảo chiếm đoạt tài sản” do Cù Thị Hoài Thanh (SN 1993, ngụ P.Hòa Khánh Bắc, Q.Liên Chiểu, Đà Nẵng) – nhân viên ngân hàng tại Đà Nẵng thực hiện.\r\n\r\nADVERTISEMENT\r\n\r\n\r\n\r\nBị can Cù Thị Hoài Thanh.\r\nTheo điều tra, Cù Thị Hoài Thanh là nhân viên của một ngân hàng chi nhánh Sông Hàn (địa chỉ tại P.Hòa Thuận Đông, Q.Hải Châu, Đà Nẵng). Trong quá trình làm việc, Thanh quen biết với bà Nguyễn Thị D.K. (ngụ Đà Nẵng).\r\n\r\nVới lý do để làm thủ tục đáo hạn ngân hàng cho khách hàng, từ tháng 9/2022 đến cuối năm 2023, Thanh nhiều lần mượn tiền bà K. Thời gian đầu, Thanh trả tiền lãi và tiền gốc đầy đủ cho bà K.\r\n\r\nADVERTISEMENT\r\n\r\n\r\nTuy nhiên sau đó, Thanh cần tiền để trả nợ cá nhân và đầu tư tiền ảo nên Thanh nói dối là cần tiền để đáo hạn ngân hàng khiến cho bà K tin tưởng. Từ ngày 07/11/2023, Thanh mượn của bà K. 3,35 tỷ đồng và dùng để trả nợ, “nướng” vào tiền ảo. Tuy nhiên Thanh bị thua lỗ hết.\r\n\r\nNgoài ra, từ ngày 29/5/2023 đến ngày 24/7/2023, Thanh nói dối là cần tiền để đáo hạn ngân hàng và mượn của ông Nguyễn Văn N. (ngụ TP.Đà Nẵng) 2,5 tỷ đồng.
Thanh cũng chiếm đoạt số tiền này để trả nợ, nướng vào tiền ảo.\r\n\r\n\r\nCơ quan CSĐT Công an TP.Đà Nẵng làm việc với bị can Cù Thị Hoài Thanh (áo sọc trắng).\r\nTừ đơn tố giác của các bị hại, Cơ quan CSĐT Công an TP.Đà Nẵng điều tra làm rõ, đến ngày 23/07/2024 khởi tố vụ án, khởi tố bị can và bắt tạm giam đối với Cù Thị Hoài Thanh.\r\n\r\nĐể phục vụ công tác điều tra mở rộng, CQĐT thông báo cho ai là bị hại của Cù Thị Hoài Thanh thì liên hệ đến Phòng Cảnh sát hình sự (số 47 Lý Tự Trọng, P.Thạch Thang, Q.Hải Châu, TP.Đà Nẵng) hoặc qua Điều tra viên Nguyễn Văn Dũng, điện thoại 0915.707.677 để trình báo, cung cấp thông tin và được hướng dẫn giải quyết.\r\n\r\nHoàng Quân\r\nADVERTISEMENT\r\n\r\n\r\nTừ Khóa Cù Thị Hoài Thanh lừa đảo nhân viên ngân hàng lừa đảo 6 tỷ lừa đảo nướng vào tiền ảo CATP.Đà Nẵng bắt kẻ lừa đảo cảnh giác tiền đáo hạn ngân hàng\r\nPlay Video\r\nXử lý thanh niên vi phạm nồng độ cồn ‘kịch khung’, còn tát vào mặt CSGT\r\nBình luận (0)\r\nNội dung bình luận\r\nTIN KHÁC\r\nPhá đường dây sản xuất dầu gió giả quy mô lớn Phá đường dây sản xuất dầu gió giả quy mô lớn Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh \r\nPhá đường dây buôn pháo lậu số lượng lớn từ Bình Phước ra Nghệ An (06/11)\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn (06/11)\r\nCông ty Xuyên Việt Oil gây thất thoát hàng ngàn tỷ đồng (kỳ cuối) (06/11)\r\nNhững cọc tiền làm mờ mắt cựu Chủ tịch HĐTV NXB Giáo dục (06/11)\r\nChủ công ty sản xuất, buôn bán 271 tấn phân bón giả, gây thiệt hại lớn cho nông dân (06/11)\r\nTPHCM: Tăng cường quản lý, kiểm tra nguồn gốc sản phẩm, hàng hóa tại chợ (05/11)\r\nTìm bị hại của “nữ quái” Lê Thị Thư lừa đảo nhiều tỷ đồng (05/11)\r\nTPHCM: Bắt giam chủ nhà thuốc Mỹ Châu và ca sĩ Quốc Kháng liên quan (05/11)\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng (05/11)\r\nNhức nhối nạn buôn lậu pháo nổ trên tuyến biên giới Tây Nam (05/11)");
            Console.WriteLine($@"Nữ nhân viên ngân hàng lừa đảo 6 tỷ đồng nướng vào tiền ảo và trả nợ\r\nThư\u0301 Sa\u0301u, 08/11/2024 11:17  | Hoàng Quân\r\n\r\n | \r\n(CAO) Quá trình làm việc tại một chi nhánh ngân hàng ở Đà Nẵng, Cù Thị Hoài Thanh (31 tuổi) vay của 2 người 6 tỷ đồng. Thanh chiếm đoạt để trả nợ và nướng vào tiền ảo nhưng bị thua sạch.\r\n\r\n“Hotgirl” lừa 47 tỷ đồng bằng chiêu đáo hạn ngân hàng\r\nBắt 'kiều nữ' lừa đảo qua vay tiền để đáo hạn cho công ty gốm sứ\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng\r\nNgày 08/11, Cơ quan CSĐT (Phòng Cảnh sát hình sự) Công an TP.Đà Nẵng ra thông báo tìm bị hại trong vụ án “Lừa đảo chiếm đoạt tài sản” do Cù Thị Hoài Thanh (SN 1993, ngụ P.Hòa Khánh Bắc, Q.Liên Chiểu, Đà Nẵng) – nhân viên ngân hàng tại Đà Nẵng thực hiện.\r\n\r\nADVERTISEMENT\r\n\r\n\r\n\r\nBị can Cù Thị Hoài Thanh.\r\nTheo điều tra, Cù Thị Hoài Thanh là nhân viên của một ngân hàng chi nhánh Sông Hàn (địa chỉ tại P.Hòa Thuận Đông, Q.Hải Châu, Đà Nẵng). Trong quá trình làm việc, Thanh quen biết với bà Nguyễn Thị D.K. (ngụ Đà Nẵng).\r\n\r\nVới lý do để làm thủ tục đáo hạn ngân hàng cho khách hàng, từ tháng 9/2022 đến cuối năm 2023, Thanh nhiều lần mượn tiền bà K. Thời gian đầu, Thanh trả tiền lãi và tiền gốc đầy đủ cho bà K.\r\n\r\nADVERTISEMENT\r\n\r\n\r\nTuy nhiên sau đó, Thanh cần tiền để trả nợ cá nhân và đầu tư tiền ảo nên Thanh nói dối là cần tiền để đáo hạn ngân hàng khiến cho bà K tin tưởng. Từ ngày 07/11/2023, Thanh mượn của bà K. 3,35 tỷ đồng và dùng để trả nợ, “nướng” vào tiền ảo. Tuy nhiên Thanh bị thua lỗ hết.\r\n\r\nNgoài ra, từ ngày 29/5/2023 đến ngày 24/7/2023, Thanh nói dối là cần tiền để đáo hạn ngân hàng và mượn của ông Nguyễn Văn N. (ngụ TP.Đà Nẵng) 2,5 tỷ đồng.
Thanh cũng chiếm đoạt số tiền này để trả nợ, nướng vào tiền ảo.\r\n\r\n\r\nCơ quan CSĐT Công an TP.Đà Nẵng làm việc với bị can Cù Thị Hoài Thanh (áo sọc trắng).\r\nTừ đơn tố giác của các bị hại, Cơ quan CSĐT Công an TP.Đà Nẵng điều tra làm rõ, đến ngày 23/07/2024 khởi tố vụ án, khởi tố bị can và bắt tạm giam đối với Cù Thị Hoài Thanh.\r\n\r\nĐể phục vụ công tác điều tra mở rộng, CQĐT thông báo cho ai là bị hại của Cù Thị Hoài Thanh thì liên hệ đến Phòng Cảnh sát hình sự (số 47 Lý Tự Trọng, P.Thạch Thang, Q.Hải Châu, TP.Đà Nẵng) hoặc qua Điều tra viên Nguyễn Văn Dũng, điện thoại 0915.707.677 để trình báo, cung cấp thông tin và được hướng dẫn giải quyết.\r\n\r\nHoàng Quân\r\nADVERTISEMENT\r\n\r\n\r\nTừ Khóa Cù Thị Hoài Thanh lừa đảo nhân viên ngân hàng lừa đảo 6 tỷ lừa đảo nướng vào tiền ảo CATP.Đà Nẵng bắt kẻ lừa đảo cảnh giác tiền đáo hạn ngân hàng\r\nPlay Video\r\nXử lý thanh niên vi phạm nồng độ cồn ‘kịch khung’, còn tát vào mặt CSGT\r\nBình luận (0)\r\nNội dung bình luận\r\nTIN KHÁC\r\nPhá đường dây sản xuất dầu gió giả quy mô lớn Phá đường dây sản xuất dầu gió giả quy mô lớn Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh \r\nPhá đường dây buôn pháo lậu số lượng lớn từ Bình Phước ra Nghệ An (06/11)\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn (06/11)\r\nCông ty Xuyên Việt Oil gây thất thoát hàng ngàn tỷ đồng (kỳ cuối) (06/11)\r\nNhững cọc tiền làm mờ mắt cựu Chủ tịch HĐTV NXB Giáo dục (06/11)\r\nChủ công ty sản xuất, buôn bán 271 tấn phân bón giả, gây thiệt hại lớn cho nông dân (06/11)\r\nTPHCM: Tăng cường quản lý, kiểm tra nguồn gốc sản phẩm, hàng hóa tại chợ (05/11)\r\nTìm bị hại của “nữ quái” Lê Thị Thư lừa đảo nhiều tỷ đồng (05/11)\r\nTPHCM: Bắt giam chủ nhà thuốc Mỹ Châu và ca sĩ Quốc Kháng liên quan (05/11)\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng (05/11)\r\nNhức nhối nạn buôn lậu pháo nổ trên tuyến biên giới Tây Nam (05/11)");
            Console.WriteLine($@"Nữ nhân viên ngân hàng lừa đảo 6 tỷ đồng nướng vào tiền ảo và trả nợ\r\nThư\u0301 Sa\u0301u, 08/11/2024 11:17  | Hoàng Quân\r\n\r\n | \r\n(CAO) Quá trình làm việc tại một chi nhánh ngân hàng ở Đà Nẵng, Cù Thị Hoài Thanh (31 tuổi) vay của 2 người 6 tỷ đồng. Thanh chiếm đoạt để trả nợ và nướng vào tiền ảo nhưng bị thua sạch.\r\n\r\n“Hotgirl” lừa 47 tỷ đồng bằng chiêu đáo hạn ngân hàng\r\nBắt 'kiều nữ' lừa đảo qua vay tiền để đáo hạn cho công ty gốm sứ\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng\r\nNgày 08/11, Cơ quan CSĐT (Phòng Cảnh sát hình sự) Công an TP.Đà Nẵng ra thông báo tìm bị hại trong vụ án “Lừa đảo chiếm đoạt tài sản” do Cù Thị Hoài Thanh (SN 1993, ngụ P.Hòa Khánh Bắc, Q.Liên Chiểu, Đà Nẵng) – nhân viên ngân hàng tại Đà Nẵng thực hiện.\r\n\r\nADVERTISEMENT\r\n\r\n\r\n\r\nBị can Cù Thị Hoài Thanh.\r\nTheo điều tra, Cù Thị Hoài Thanh là nhân viên của một ngân hàng chi nhánh Sông Hàn (địa chỉ tại P.Hòa Thuận Đông, Q.Hải Châu, Đà Nẵng). Trong quá trình làm việc, Thanh quen biết với bà Nguyễn Thị D.K. (ngụ Đà Nẵng).\r\n\r\nVới lý do để làm thủ tục đáo hạn ngân hàng cho khách hàng, từ tháng 9/2022 đến cuối năm 2023, Thanh nhiều lần mượn tiền bà K. Thời gian đầu, Thanh trả tiền lãi và tiền gốc đầy đủ cho bà K.\r\n\r\nADVERTISEMENT\r\n\r\n\r\nTuy nhiên sau đó, Thanh cần tiền để trả nợ cá nhân và đầu tư tiền ảo nên Thanh nói dối là cần tiền để đáo hạn ngân hàng khiến cho bà K tin tưởng. Từ ngày 07/11/2023, Thanh mượn của bà K. 3,35 tỷ đồng và dùng để trả nợ, “nướng” vào tiền ảo. Tuy nhiên Thanh bị thua lỗ hết.\r\n\r\nNgoài ra, từ ngày 29/5/2023 đến ngày 24/7/2023, Thanh nói dối là cần tiền để đáo hạn ngân hàng và mượn của ông Nguyễn Văn N. (ngụ TP.Đà Nẵng) 2,5 tỷ đồng.
Thanh cũng chiếm đoạt số tiền này để trả nợ, nướng vào tiền ảo.\r\n\r\n\r\nCơ quan CSĐT Công an TP.Đà Nẵng làm việc với bị can Cù Thị Hoài Thanh (áo sọc trắng).\r\nTừ đơn tố giác của các bị hại, Cơ quan CSĐT Công an TP.Đà Nẵng điều tra làm rõ, đến ngày 23/07/2024 khởi tố vụ án, khởi tố bị can và bắt tạm giam đối với Cù Thị Hoài Thanh.\r\n\r\nĐể phục vụ công tác điều tra mở rộng, CQĐT thông báo cho ai là bị hại của Cù Thị Hoài Thanh thì liên hệ đến Phòng Cảnh sát hình sự (số 47 Lý Tự Trọng, P.Thạch Thang, Q.Hải Châu, TP.Đà Nẵng) hoặc qua Điều tra viên Nguyễn Văn Dũng, điện thoại 0915.707.677 để trình báo, cung cấp thông tin và được hướng dẫn giải quyết.\r\n\r\nHoàng Quân\r\nADVERTISEMENT\r\n\r\n\r\nTừ Khóa Cù Thị Hoài Thanh lừa đảo nhân viên ngân hàng lừa đảo 6 tỷ lừa đảo nướng vào tiền ảo CATP.Đà Nẵng bắt kẻ lừa đảo cảnh giác tiền đáo hạn ngân hàng\r\nPlay Video\r\nXử lý thanh niên vi phạm nồng độ cồn ‘kịch khung’, còn tát vào mặt CSGT\r\nBình luận (0)\r\nNội dung bình luận\r\nTIN KHÁC\r\nPhá đường dây sản xuất dầu gió giả quy mô lớn Phá đường dây sản xuất dầu gió giả quy mô lớn Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh \r\nPhá đường dây buôn pháo lậu số lượng lớn từ Bình Phước ra Nghệ An (06/11)\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn (06/11)\r\nCông ty Xuyên Việt Oil gây thất thoát hàng ngàn tỷ đồng (kỳ cuối) (06/11)\r\nNhững cọc tiền làm mờ mắt cựu Chủ tịch HĐTV NXB Giáo dục (06/11)\r\nChủ công ty sản xuất, buôn bán 271 tấn phân bón giả, gây thiệt hại lớn cho nông dân (06/11)\r\nTPHCM: Tăng cường quản lý, kiểm tra nguồn gốc sản phẩm, hàng hóa tại chợ (05/11)\r\nTìm bị hại của “nữ quái” Lê Thị Thư lừa đảo nhiều tỷ đồng (05/11)\r\nTPHCM: Bắt giam chủ nhà thuốc Mỹ Châu và ca sĩ Quốc Kháng liên quan (05/11)\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng (05/11)\r\nNhức nhối nạn buôn lậu pháo nổ trên tuyến biên giới Tây Nam (05/11)");
            Console.WriteLine($@"Nữ nhân viên ngân hàng lừa đảo 6 tỷ đồng nướng vào tiền ảo và trả nợ\r\nThư\u0301 Sa\u0301u, 08/11/2024 11:17  | Hoàng Quân\r\n\r\n | \r\n(CAO) Quá trình làm việc tại một chi nhánh ngân hàng ở Đà Nẵng, Cù Thị Hoài Thanh (31 tuổi) vay của 2 người 6 tỷ đồng. Thanh chiếm đoạt để trả nợ và nướng vào tiền ảo nhưng bị thua sạch.\r\n\r\n“Hotgirl” lừa 47 tỷ đồng bằng chiêu đáo hạn ngân hàng\r\nBắt 'kiều nữ' lừa đảo qua vay tiền để đáo hạn cho công ty gốm sứ\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng\r\nNgày 08/11, Cơ quan CSĐT (Phòng Cảnh sát hình sự) Công an TP.Đà Nẵng ra thông báo tìm bị hại trong vụ án “Lừa đảo chiếm đoạt tài sản” do Cù Thị Hoài Thanh (SN 1993, ngụ P.Hòa Khánh Bắc, Q.Liên Chiểu, Đà Nẵng) – nhân viên ngân hàng tại Đà Nẵng thực hiện.\r\n\r\nADVERTISEMENT\r\n\r\n\r\n\r\nBị can Cù Thị Hoài Thanh.\r\nTheo điều tra, Cù Thị Hoài Thanh là nhân viên của một ngân hàng chi nhánh Sông Hàn (địa chỉ tại P.Hòa Thuận Đông, Q.Hải Châu, Đà Nẵng). Trong quá trình làm việc, Thanh quen biết với bà Nguyễn Thị D.K. (ngụ Đà Nẵng).\r\n\r\nVới lý do để làm thủ tục đáo hạn ngân hàng cho khách hàng, từ tháng 9/2022 đến cuối năm 2023, Thanh nhiều lần mượn tiền bà K. Thời gian đầu, Thanh trả tiền lãi và tiền gốc đầy đủ cho bà K.\r\n\r\nADVERTISEMENT\r\n\r\n\r\nTuy nhiên sau đó, Thanh cần tiền để trả nợ cá nhân và đầu tư tiền ảo nên Thanh nói dối là cần tiền để đáo hạn ngân hàng khiến cho bà K tin tưởng. Từ ngày 07/11/2023, Thanh mượn của bà K. 3,35 tỷ đồng và dùng để trả nợ, “nướng” vào tiền ảo. Tuy nhiên Thanh bị thua lỗ hết.\r\n\r\nNgoài ra, từ ngày 29/5/2023 đến ngày 24/7/2023, Thanh nói dối là cần tiền để đáo hạn ngân hàng và mượn của ông Nguyễn Văn N. (ngụ TP.Đà Nẵng) 2,5 tỷ đồng.
Thanh cũng chiếm đoạt số tiền này để trả nợ, nướng vào tiền ảo.\r\n\r\n\r\nCơ quan CSĐT Công an TP.Đà Nẵng làm việc với bị can Cù Thị Hoài Thanh (áo sọc trắng).\r\nTừ đơn tố giác của các bị hại, Cơ quan CSĐT Công an TP.Đà Nẵng điều tra làm rõ, đến ngày 23/07/2024 khởi tố vụ án, khởi tố bị can và bắt tạm giam đối với Cù Thị Hoài Thanh.\r\n\r\nĐể phục vụ công tác điều tra mở rộng, CQĐT thông báo cho ai là bị hại của Cù Thị Hoài Thanh thì liên hệ đến Phòng Cảnh sát hình sự (số 47 Lý Tự Trọng, P.Thạch Thang, Q.Hải Châu, TP.Đà Nẵng) hoặc qua Điều tra viên Nguyễn Văn Dũng, điện thoại 0915.707.677 để trình báo, cung cấp thông tin và được hướng dẫn giải quyết.\r\n\r\nHoàng Quân\r\nADVERTISEMENT\r\n\r\n\r\nTừ Khóa Cù Thị Hoài Thanh lừa đảo nhân viên ngân hàng lừa đảo 6 tỷ lừa đảo nướng vào tiền ảo CATP.Đà Nẵng bắt kẻ lừa đảo cảnh giác tiền đáo hạn ngân hàng\r\nPlay Video\r\nXử lý thanh niên vi phạm nồng độ cồn ‘kịch khung’, còn tát vào mặt CSGT\r\nBình luận (0)\r\nNội dung bình luận\r\nTIN KHÁC\r\nPhá đường dây sản xuất dầu gió giả quy mô lớn Phá đường dây sản xuất dầu gió giả quy mô lớn Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh \r\nPhá đường dây buôn pháo lậu số lượng lớn từ Bình Phước ra Nghệ An (06/11)\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn (06/11)\r\nCông ty Xuyên Việt Oil gây thất thoát hàng ngàn tỷ đồng (kỳ cuối) (06/11)\r\nNhững cọc tiền làm mờ mắt cựu Chủ tịch HĐTV NXB Giáo dục (06/11)\r\nChủ công ty sản xuất, buôn bán 271 tấn phân bón giả, gây thiệt hại lớn cho nông dân (06/11)\r\nTPHCM: Tăng cường quản lý, kiểm tra nguồn gốc sản phẩm, hàng hóa tại chợ (05/11)\r\nTìm bị hại của “nữ quái” Lê Thị Thư lừa đảo nhiều tỷ đồng (05/11)\r\nTPHCM: Bắt giam chủ nhà thuốc Mỹ Châu và ca sĩ Quốc Kháng liên quan (05/11)\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng (05/11)\r\nNhức nhối nạn buôn lậu pháo nổ trên tuyến biên giới Tây Nam (05/11)");
            Console.WriteLine($@"Nữ nhân viên ngân hàng lừa đảo 6 tỷ đồng nướng vào tiền ảo và trả nợ\r\nThư\u0301 Sa\u0301u, 08/11/2024 11:17  | Hoàng Quân\r\n\r\n | \r\n(CAO) Quá trình làm việc tại một chi nhánh ngân hàng ở Đà Nẵng, Cù Thị Hoài Thanh (31 tuổi) vay của 2 người 6 tỷ đồng. Thanh chiếm đoạt để trả nợ và nướng vào tiền ảo nhưng bị thua sạch.\r\n\r\n“Hotgirl” lừa 47 tỷ đồng bằng chiêu đáo hạn ngân hàng\r\nBắt 'kiều nữ' lừa đảo qua vay tiền để đáo hạn cho công ty gốm sứ\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng\r\nNgày 08/11, Cơ quan CSĐT (Phòng Cảnh sát hình sự) Công an TP.Đà Nẵng ra thông báo tìm bị hại trong vụ án “Lừa đảo chiếm đoạt tài sản” do Cù Thị Hoài Thanh (SN 1993, ngụ P.Hòa Khánh Bắc, Q.Liên Chiểu, Đà Nẵng) – nhân viên ngân hàng tại Đà Nẵng thực hiện.\r\n\r\nADVERTISEMENT\r\n\r\n\r\n\r\nBị can Cù Thị Hoài Thanh.\r\nTheo điều tra, Cù Thị Hoài Thanh là nhân viên của một ngân hàng chi nhánh Sông Hàn (địa chỉ tại P.Hòa Thuận Đông, Q.Hải Châu, Đà Nẵng). Trong quá trình làm việc, Thanh quen biết với bà Nguyễn Thị D.K. (ngụ Đà Nẵng).\r\n\r\nVới lý do để làm thủ tục đáo hạn ngân hàng cho khách hàng, từ tháng 9/2022 đến cuối năm 2023, Thanh nhiều lần mượn tiền bà K. Thời gian đầu, Thanh trả tiền lãi và tiền gốc đầy đủ cho bà K.\r\n\r\nADVERTISEMENT\r\n\r\n\r\nTuy nhiên sau đó, Thanh cần tiền để trả nợ cá nhân và đầu tư tiền ảo nên Thanh nói dối là cần tiền để đáo hạn ngân hàng khiến cho bà K tin tưởng. Từ ngày 07/11/2023, Thanh mượn của bà K. 3,35 tỷ đồng và dùng để trả nợ, “nướng” vào tiền ảo. Tuy nhiên Thanh bị thua lỗ hết.\r\n\r\nNgoài ra, từ ngày 29/5/2023 đến ngày 24/7/2023, Thanh nói dối là cần tiền để đáo hạn ngân hàng và mượn của ông Nguyễn Văn N. (ngụ TP.Đà Nẵng) 2,5 tỷ đồng.
Thanh cũng chiếm đoạt số tiền này để trả nợ, nướng vào tiền ảo.\r\n\r\n\r\nCơ quan CSĐT Công an TP.Đà Nẵng làm việc với bị can Cù Thị Hoài Thanh (áo sọc trắng).\r\nTừ đơn tố giác của các bị hại, Cơ quan CSĐT Công an TP.Đà Nẵng điều tra làm rõ, đến ngày 23/07/2024 khởi tố vụ án, khởi tố bị can và bắt tạm giam đối với Cù Thị Hoài Thanh.\r\n\r\nĐể phục vụ công tác điều tra mở rộng, CQĐT thông báo cho ai là bị hại của Cù Thị Hoài Thanh thì liên hệ đến Phòng Cảnh sát hình sự (số 47 Lý Tự Trọng, P.Thạch Thang, Q.Hải Châu, TP.Đà Nẵng) hoặc qua Điều tra viên Nguyễn Văn Dũng, điện thoại 0915.707.677 để trình báo, cung cấp thông tin và được hướng dẫn giải quyết.\r\n\r\nHoàng Quân\r\nADVERTISEMENT\r\n\r\n\r\nTừ Khóa Cù Thị Hoài Thanh lừa đảo nhân viên ngân hàng lừa đảo 6 tỷ lừa đảo nướng vào tiền ảo CATP.Đà Nẵng bắt kẻ lừa đảo cảnh giác tiền đáo hạn ngân hàng\r\nPlay Video\r\nXử lý thanh niên vi phạm nồng độ cồn ‘kịch khung’, còn tát vào mặt CSGT\r\nBình luận (0)\r\nNội dung bình luận\r\nTIN KHÁC\r\nPhá đường dây sản xuất dầu gió giả quy mô lớn Phá đường dây sản xuất dầu gió giả quy mô lớn Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh \r\nPhá đường dây buôn pháo lậu số lượng lớn từ Bình Phước ra Nghệ An (06/11)\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn (06/11)\r\nCông ty Xuyên Việt Oil gây thất thoát hàng ngàn tỷ đồng (kỳ cuối) (06/11)\r\nNhững cọc tiền làm mờ mắt cựu Chủ tịch HĐTV NXB Giáo dục (06/11)\r\nChủ công ty sản xuất, buôn bán 271 tấn phân bón giả, gây thiệt hại lớn cho nông dân (06/11)\r\nTPHCM: Tăng cường quản lý, kiểm tra nguồn gốc sản phẩm, hàng hóa tại chợ (05/11)\r\nTìm bị hại của “nữ quái” Lê Thị Thư lừa đảo nhiều tỷ đồng (05/11)\r\nTPHCM: Bắt giam chủ nhà thuốc Mỹ Châu và ca sĩ Quốc Kháng liên quan (05/11)\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng (05/11)\r\nNhức nhối nạn buôn lậu pháo nổ trên tuyến biên giới Tây Nam (05/11)");
            Console.WriteLine($@"Nữ nhân viên ngân hàng lừa đảo 6 tỷ đồng nướng vào tiền ảo và trả nợ\r\nThư\u0301 Sa\u0301u, 08/11/2024 11:17  | Hoàng Quân\r\n\r\n | \r\n(CAO) Quá trình làm việc tại một chi nhánh ngân hàng ở Đà Nẵng, Cù Thị Hoài Thanh (31 tuổi) vay của 2 người 6 tỷ đồng. Thanh chiếm đoạt để trả nợ và nướng vào tiền ảo nhưng bị thua sạch.\r\n\r\n“Hotgirl” lừa 47 tỷ đồng bằng chiêu đáo hạn ngân hàng\r\nBắt 'kiều nữ' lừa đảo qua vay tiền để đáo hạn cho công ty gốm sứ\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng\r\nNgày 08/11, Cơ quan CSĐT (Phòng Cảnh sát hình sự) Công an TP.Đà Nẵng ra thông báo tìm bị hại trong vụ án “Lừa đảo chiếm đoạt tài sản” do Cù Thị Hoài Thanh (SN 1993, ngụ P.Hòa Khánh Bắc, Q.Liên Chiểu, Đà Nẵng) – nhân viên ngân hàng tại Đà Nẵng thực hiện.\r\n\r\nADVERTISEMENT\r\n\r\n\r\n\r\nBị can Cù Thị Hoài Thanh.\r\nTheo điều tra, Cù Thị Hoài Thanh là nhân viên của một ngân hàng chi nhánh Sông Hàn (địa chỉ tại P.Hòa Thuận Đông, Q.Hải Châu, Đà Nẵng). Trong quá trình làm việc, Thanh quen biết với bà Nguyễn Thị D.K. (ngụ Đà Nẵng).\r\n\r\nVới lý do để làm thủ tục đáo hạn ngân hàng cho khách hàng, từ tháng 9/2022 đến cuối năm 2023, Thanh nhiều lần mượn tiền bà K. Thời gian đầu, Thanh trả tiền lãi và tiền gốc đầy đủ cho bà K.\r\n\r\nADVERTISEMENT\r\n\r\n\r\nTuy nhiên sau đó, Thanh cần tiền để trả nợ cá nhân và đầu tư tiền ảo nên Thanh nói dối là cần tiền để đáo hạn ngân hàng khiến cho bà K tin tưởng. Từ ngày 07/11/2023, Thanh mượn của bà K. 3,35 tỷ đồng và dùng để trả nợ, “nướng” vào tiền ảo. Tuy nhiên Thanh bị thua lỗ hết.\r\n\r\nNgoài ra, từ ngày 29/5/2023 đến ngày 24/7/2023, Thanh nói dối là cần tiền để đáo hạn ngân hàng và mượn của ông Nguyễn Văn N. (ngụ TP.Đà Nẵng) 2,5 tỷ đồng.
Thanh cũng chiếm đoạt số tiền này để trả nợ, nướng vào tiền ảo.\r\n\r\n\r\nCơ quan CSĐT Công an TP.Đà Nẵng làm việc với bị can Cù Thị Hoài Thanh (áo sọc trắng).\r\nTừ đơn tố giác của các bị hại, Cơ quan CSĐT Công an TP.Đà Nẵng điều tra làm rõ, đến ngày 23/07/2024 khởi tố vụ án, khởi tố bị can và bắt tạm giam đối với Cù Thị Hoài Thanh.\r\n\r\nĐể phục vụ công tác điều tra mở rộng, CQĐT thông báo cho ai là bị hại của Cù Thị Hoài Thanh thì liên hệ đến Phòng Cảnh sát hình sự (số 47 Lý Tự Trọng, P.Thạch Thang, Q.Hải Châu, TP.Đà Nẵng) hoặc qua Điều tra viên Nguyễn Văn Dũng, điện thoại 0915.707.677 để trình báo, cung cấp thông tin và được hướng dẫn giải quyết.\r\n\r\nHoàng Quân\r\nADVERTISEMENT\r\n\r\n\r\nTừ Khóa Cù Thị Hoài Thanh lừa đảo nhân viên ngân hàng lừa đảo 6 tỷ lừa đảo nướng vào tiền ảo CATP.Đà Nẵng bắt kẻ lừa đảo cảnh giác tiền đáo hạn ngân hàng\r\nPlay Video\r\nXử lý thanh niên vi phạm nồng độ cồn ‘kịch khung’, còn tát vào mặt CSGT\r\nBình luận (0)\r\nNội dung bình luận\r\nTIN KHÁC\r\nPhá đường dây sản xuất dầu gió giả quy mô lớn Phá đường dây sản xuất dầu gió giả quy mô lớn Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh \r\nPhá đường dây buôn pháo lậu số lượng lớn từ Bình Phước ra Nghệ An (06/11)\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn (06/11)\r\nCông ty Xuyên Việt Oil gây thất thoát hàng ngàn tỷ đồng (kỳ cuối) (06/11)\r\nNhững cọc tiền làm mờ mắt cựu Chủ tịch HĐTV NXB Giáo dục (06/11)\r\nChủ công ty sản xuất, buôn bán 271 tấn phân bón giả, gây thiệt hại lớn cho nông dân (06/11)\r\nTPHCM: Tăng cường quản lý, kiểm tra nguồn gốc sản phẩm, hàng hóa tại chợ (05/11)\r\nTìm bị hại của “nữ quái” Lê Thị Thư lừa đảo nhiều tỷ đồng (05/11)\r\nTPHCM: Bắt giam chủ nhà thuốc Mỹ Châu và ca sĩ Quốc Kháng liên quan (05/11)\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng (05/11)\r\nNhức nhối nạn buôn lậu pháo nổ trên tuyến biên giới Tây Nam (05/11)");
            Console.WriteLine($@"Nữ nhân viên ngân hàng lừa đảo 6 tỷ đồng nướng vào tiền ảo và trả nợ\r\nThư\u0301 Sa\u0301u, 08/11/2024 11:17  | Hoàng Quân\r\n\r\n | \r\n(CAO) Quá trình làm việc tại một chi nhánh ngân hàng ở Đà Nẵng, Cù Thị Hoài Thanh (31 tuổi) vay của 2 người 6 tỷ đồng. Thanh chiếm đoạt để trả nợ và nướng vào tiền ảo nhưng bị thua sạch.\r\n\r\n“Hotgirl” lừa 47 tỷ đồng bằng chiêu đáo hạn ngân hàng\r\nBắt 'kiều nữ' lừa đảo qua vay tiền để đáo hạn cho công ty gốm sứ\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng\r\nNgày 08/11, Cơ quan CSĐT (Phòng Cảnh sát hình sự) Công an TP.Đà Nẵng ra thông báo tìm bị hại trong vụ án “Lừa đảo chiếm đoạt tài sản” do Cù Thị Hoài Thanh (SN 1993, ngụ P.Hòa Khánh Bắc, Q.Liên Chiểu, Đà Nẵng) – nhân viên ngân hàng tại Đà Nẵng thực hiện.\r\n\r\nADVERTISEMENT\r\n\r\n\r\n\r\nBị can Cù Thị Hoài Thanh.\r\nTheo điều tra, Cù Thị Hoài Thanh là nhân viên của một ngân hàng chi nhánh Sông Hàn (địa chỉ tại P.Hòa Thuận Đông, Q.Hải Châu, Đà Nẵng). Trong quá trình làm việc, Thanh quen biết với bà Nguyễn Thị D.K. (ngụ Đà Nẵng).\r\n\r\nVới lý do để làm thủ tục đáo hạn ngân hàng cho khách hàng, từ tháng 9/2022 đến cuối năm 2023, Thanh nhiều lần mượn tiền bà K. Thời gian đầu, Thanh trả tiền lãi và tiền gốc đầy đủ cho bà K.\r\n\r\nADVERTISEMENT\r\n\r\n\r\nTuy nhiên sau đó, Thanh cần tiền để trả nợ cá nhân và đầu tư tiền ảo nên Thanh nói dối là cần tiền để đáo hạn ngân hàng khiến cho bà K tin tưởng. Từ ngày 07/11/2023, Thanh mượn của bà K. 3,35 tỷ đồng và dùng để trả nợ, “nướng” vào tiền ảo. Tuy nhiên Thanh bị thua lỗ hết.\r\n\r\nNgoài ra, từ ngày 29/5/2023 đến ngày 24/7/2023, Thanh nói dối là cần tiền để đáo hạn ngân hàng và mượn của ông Nguyễn Văn N. (ngụ TP.Đà Nẵng) 2,5 tỷ đồng.
Thanh cũng chiếm đoạt số tiền này để trả nợ, nướng vào tiền ảo.\r\n\r\n\r\nCơ quan CSĐT Công an TP.Đà Nẵng làm việc với bị can Cù Thị Hoài Thanh (áo sọc trắng).\r\nTừ đơn tố giác của các bị hại, Cơ quan CSĐT Công an TP.Đà Nẵng điều tra làm rõ, đến ngày 23/07/2024 khởi tố vụ án, khởi tố bị can và bắt tạm giam đối với Cù Thị Hoài Thanh.\r\n\r\nĐể phục vụ công tác điều tra mở rộng, CQĐT thông báo cho ai là bị hại của Cù Thị Hoài Thanh thì liên hệ đến Phòng Cảnh sát hình sự (số 47 Lý Tự Trọng, P.Thạch Thang, Q.Hải Châu, TP.Đà Nẵng) hoặc qua Điều tra viên Nguyễn Văn Dũng, điện thoại 0915.707.677 để trình báo, cung cấp thông tin và được hướng dẫn giải quyết.\r\n\r\nHoàng Quân\r\nADVERTISEMENT\r\n\r\n\r\nTừ Khóa Cù Thị Hoài Thanh lừa đảo nhân viên ngân hàng lừa đảo 6 tỷ lừa đảo nướng vào tiền ảo CATP.Đà Nẵng bắt kẻ lừa đảo cảnh giác tiền đáo hạn ngân hàng\r\nPlay Video\r\nXử lý thanh niên vi phạm nồng độ cồn ‘kịch khung’, còn tát vào mặt CSGT\r\nBình luận (0)\r\nNội dung bình luận\r\nTIN KHÁC\r\nPhá đường dây sản xuất dầu gió giả quy mô lớn Phá đường dây sản xuất dầu gió giả quy mô lớn Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Hàng trăm người bao vây Công ty GFDI để đòi tiền đầu tư Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh Khởi tố vụ án gây thất thoát, lãng phí khoáng sản đặc biệt lớn xa\u0309y ra tại Công ty Hưng Thịnh \r\nPhá đường dây buôn pháo lậu số lượng lớn từ Bình Phước ra Nghệ An (06/11)\r\nNhân viên ngân hàng chiếm đoạt 4 tỷ đồng qua lừa vay tiền đáo hạn (06/11)\r\nCông ty Xuyên Việt Oil gây thất thoát hàng ngàn tỷ đồng (kỳ cuối) (06/11)\r\nNhững cọc tiền làm mờ mắt cựu Chủ tịch HĐTV NXB Giáo dục (06/11)\r\nChủ công ty sản xuất, buôn bán 271 tấn phân bón giả, gây thiệt hại lớn cho nông dân (06/11)\r\nTPHCM: Tăng cường quản lý, kiểm tra nguồn gốc sản phẩm, hàng hóa tại chợ (05/11)\r\nTìm bị hại của “nữ quái” Lê Thị Thư lừa đảo nhiều tỷ đồng (05/11)\r\nTPHCM: Bắt giam chủ nhà thuốc Mỹ Châu và ca sĩ Quốc Kháng liên quan (05/11)\r\nTPHCM: Khởi tố hai nữ nhân viên ngân hàng liên quan vụ 'rút ruột' hơn 7 tỷ đồng (05/11)\r\nNhức nhối nạn buôn lậu pháo nổ trên tuyến biên giới Tây Nam (05/11)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine();

            return shapeRepository.GetAll();
        }
    }
}
