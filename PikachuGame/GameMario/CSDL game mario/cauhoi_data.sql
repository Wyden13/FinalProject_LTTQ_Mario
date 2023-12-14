<<<<<<< HEAD:GameMario/CSDL game mario/cauhoi_data.sql
﻿CREATE DATABASE FTM 
GO
USE [FTM]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Mon
(
MAMON INT NOT NULL PRIMARY KEY,
TEN NVARCHAR(50),
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE CauHoi
(
 NOIDUNG NVARCHAR(3000) NOT NULL,
 MAMON INT NOT NULL, 
 DA1 NVARCHAR(3000),
 DA2 NVARCHAR(3000),
 DA3 NVARCHAR(3000),
 DA4 NVARCHAR(3000),
 DA CHAR NOT NULL,
)
GO
ALTER TABLE CauHoi 
ADD CONSTRAINT FK_CH_M_MAMON FOREIGN KEY (MAMON) REFERENCES Mon(MAMON)

INSERT INTO Mon VALUES ('001',N'Nhập môn lập trình')
INSERT INTO Mon VALUES ('002', N'Lập trình hướng đối tượng')
INSERT INTO Mon VALUES ('003',N'Cấu trúc dữ liệu và giải thuật')
INSERT INTO Mon VALUES ('004', N'Nhập môn mạng máy tính')
INSERT INTO Mon VALUES ('005', N'Hệ điều hành')



INSERT INTO CauHoi VALUES (N'Độ ưu tiên đúng đối với các toán tử logic là:','001','AND, NOT, OR', 'NOT, OR, AND','OR, NOT, AND','NOT, AND, OR','D')
INSERT INTO CauHoi VALUES (N'Sử dụng khai báo “double a[12]”, phần tử a[7] là phần tử thứ bao nhiêu trong mảng a:', '001','6','7','8','9', 'C')
INSERT INTO CauHoi VALUES (N'Phép trừ 1 con trỏ với một số nguyên sẽ là: ','001', N'Một số nguyên', N'Một con trỏ cùng kiểu',N'Cả hai đều đúng',N'Đáp án khác','B')
INSERT INTO CauHoi VALUES (N'Kích thước của biến con trỏ là: ','001', '2 byte','1 byte', '4 byte', '3 byte', 'A')
INSERT INTO CauHoi VALUES (N'Giá trị logic của biểu thức sau là gì: !(1&&1||1&&0): ', '001', '1', '0','-1', 'Lỗi','B')


INSERT INTO CauHoi VALUES (N'Trừu tượng hóa là: ', '002', N'Phương pháp quan tâm đến mọi chi tiết của đối tượng.',N'Phương pháp chỉ quan tâm đến những chi tiết cần thiết (chi tiết chính) và bỏ qua những chi tiết không cần thiết.',N'Phương pháp thay thế những chi tiết chính bằng những chi tiết tương tự.',N'Không có đáp án đúng','B')
INSERT INTO CauHoi VALUES (N'Khi khai báo thành phần thuộc tính và phương thức của lớp , nếu không khai báo từ khóa private,  public, hay protected thì mặc định sẽ là:','002','private', 'public', 'protected',N'Lỗi, cần khai báo 1 trong 3','A')
INSERT INTO CauHoi VALUES (N'Từ khóa nào sau đây được dùng khi lớp con muốn cài lại phương thức được thừa kế từ lớp cha: ','002','New', 'Virtual','Override','Abstract','C') 
INSERT INTO CauHoi VALUES (N'OOP là viết tắt của: ', '002','Object Open Programming', 'Object Oriented Programming', 'Object Oriented Proccessing','Open Object Programming', 'B')
INSERT INTO CauHoi VALUES (N'Đặc điểm của Tính đa hình?', '002', N'Khả năng một hàm, thủ tục có thể được kế thừa lại', N'Khả năng một thông điệp có thể được truyền lại cho lớp con của nó',N'Khả năng một hàm, thủ tục được sử dụng lại',N'Khả năng một thông điệp có thể thay đổi cách thể hiện của nó theo lớp cụ thể của đối tượng được nhận thông điệp','D')

INSERT INTO CauHoi VALUES (N'Thao tác POP(x) dùng trong Stack là để:', '003', N'Xóa bỏ một phần tử bất kì khỏi Stack', N'Xóa bỏ một dãy các phần tử ra khỏi Stack', N'Lấy phần tử đầu tiên ra khỏi Stack', N'Lấy một phần tử cuối cùng ra khỏi đỉnh Stack', 'D')
INSERT INTO CauHoi VALUES (N'Thao tác Push(x) dùng trong Stack là để:','003',N'Bổ sung một dãy các phần tử vào đỉnh Stack',N'Bổ sung một phần tử bất kì vào Stack',N'Bổ sung một phần tử vào đỉnh Stack',N'Bổ sung một phần tử vào đầu Stack','C')
INSERT INTO CauHoi VALUES (N'Cho Stack gồm 5 phần tử {12, 5, 20, 23, 25}, trong đó 25 là phần tử ở đỉnh Stack. Để lấy ra phần tử thứ 4 trong Stack ta phải làm thế nào?', '003','POP(25),POP(23), PUSH(25)','POP(23),PUSH(25)','POP(25),PUSH(23)','POP(25),POP(23)','A')
INSERT INTO CauHoi VALUES (N'Trong biểu diễn dữ liệu dưới dạng cây, cấp của cây chính: ','003',N'Tổng số nút trên cây',N'Cấp cao nhất của nút gốc', N'Cấp cao nhất của nút lá',N'Cấp cao nhất của một nút trên cây','D')
INSERT INTO CauHoi VALUES (N'Trong các giải thuật sắp xếp, giải thuật nào áp dụng phương pháp "Chia để trị"?', '003', N'Quick sort, Heap sort', 'Quick sort, Insert sort', 'Quick sort, Merge sort', 'Quick sort, Bubble sort', 'C')
INSERT INTO CauHoi VALUES (N'Hàng đợi còn được gọi là danh sách kiểu: ','003','LIFO','FILO','LOLO','FIFO','D')
INSERT INTO CauHoi VALUES (N'Ý tưởng phương pháp sắp xếp nổi bọt (bubble sort) là: ','003',N'So sánh hai phần tử kề nhau nếu chưa đúng thì đổi chỗ',N'Dựa vào tư tưởng "chia để trị"',N'Chọn phần tử bé nhất xếp vào vị trí thứ nhất,tương tự đối với phần tử nhỏ thứ hai,ba...',N'Lần lượt lấy phần tử của danh sách chèn vị trí thích hợp của danh sách đã sắp','A')

INSERT INTO CauHoi VALUES (N'Giao thức nào thuộc tầng Application?','004','TCP','HTTP','NFS','IP','B')
INSERT INTO CauHoi VALUES (N'Địa chỉ IPv6 gồm bao nhiêu bit', '004','32','48','64','128','D')
INSERT INTO CauHoi VALUES (N'TCP làm việc ở lớp nào của mô hình OSI?','004','Layer 4','Layer 5','Layer 6','Layer 7','A')
INSERT INTO CauHoi VALUES (N'Để kết nối Router với Router ta dùng:','004',N'Cáp chéo (Cross-Cable)',N'Cáp thẳng (Straight Cable)','Rollover Cable',N'Tất cả đều sai','A')
INSERT INTO CauHoi VALUES (N'Lệnh nào sau đây cho biết địa chỉ IP của máy tính:','004','IP','IPCONFIG','FTP','TCP_IP','B')
INSERT INTO CauHoi VALUES (N'Checksum trong gói dữ liệu UDP có độ dài:','004','4 bit','8 bit', '16 bit','32 bit', 'B')
INSERT INTO CauHoi VALUES (N'SMTP sử dụng cổng số bao nhiêu:','004','143','25','80','225','B')
INSERT INTO CauHoi VALUES (N'Phản hồi nào cho biết client đang yêu cầu thông điệp không tồn tại trên máy chủ?','004','200 OK','400 Bad Request','301 Moved Permanently','404 Not Found','D')
INSERT INTO CauHoi VALUES (N'Các đơn vị dữ liệu giao thức trong mô hình OSI được gọi là:','004','UDP','OSI','PDU','Packet','C')
INSERT INTO CauHoi VALUES (N'Trong giao thức HTTP, phương thức nào được sử dụng để yêu cầu dữ liệu từ máy chủ?','004','GET','POST','PUT','DELETE','A')
INSERT INTO CauHoi VALUES (N'Trong giao thức DNS, bản ghi nào được sử dụng để ánh xạ tên miền thành địa chỉ IP?','004','A','CNAME','MX','PTR','A')
INSERT INTO CauHoi VALUES (N'RDT sử dụng cơ chế nào để đồng bộ hóa quá trình truyền tin giữa người gửi và người nhận?','004','Go-Back-N','Selective Repeat','Stop-and-Wait','Piggybacking','C')
INSERT INTO CauHoi VALUES (N'Thứ tự đúng từ trên xuống dưới trong mô hình chồng giao thức Internet phân tầng','004','Application – Transport – Network – Physical – Link','Physical – Link – Network – Transport - Application',' Application – Network – Transport – Link - Physical
','Application – Transport – Network – Link – Physical','D')

INSERT INTO CauHoi VALUES (N'Chọn phát biểu SAI về các tác vụ đối với tiến trình?','005',N' Tiến trình con nhận tài nguyên từ hệ điều hành hoặc từ tiến trình cha.',N'Không gian địa chỉ của tiến trình con luôn được nhân bản từ tiến trình cha.',N'Tiến trình có thể tự kết thúc hoặc bị kết thúc bởi tiến trình khác.',N'Tiến trình con chỉ có thể sử dụng một phần hoặc toàn bộ tài nguyên của tiến trình cha','B')
INSERT INTO CauHoi VALUES (N'Chọn phát biểu ĐÚNG về cơ chế phân trang?','005',N'Bộ nhớ vật lý được chia thành các khung trang còn bộ nhớ luận lý được chia thành các trang',N' Hệ điều hành tạo một bảng phân trang cho tất cả các tiến trình',N'Thanh ghi page-table length (PTLR) xác định vị trí của bảng phân trang',N'Kích thước của bảng phân trang được xác định bởi thanh ghi page-table base (PTBR)','A')
INSERT INTO CauHoi VALUES (N'Các giải pháp đồng bộ được chia thành những nhóm nào?','005','Busy Waiting – Sleep & Wakeup','Busy Waiting –Circular Wait','Sleep & Wakeup – Hold & Wait','Sleep & Wakeup – Mutual Exclusion','A')
INSERT INTO CauHoi VALUES (N'Chọn phát biểu SAI trong các phát biểu sau?','005',N'Nếu hệ thống đang ở trạng thái an toàn thì tồn tại ít nhất một chuỗi thứ tự an toàn trong hệ thống',N'Nếu đồ thị cấp phát tài nguyên có chu trình thì có deadlock xảy ra',N'Nếu hệ thống đang ở trạng thái không an toàn thì có thể xảy ra deadlock',N'Một tiến trình gọi là deadlock nếu nó đang đợi một sự kiện mà sẽ không bao giờ xảy ra','B')
INSERT INTO CauHoi VALUES (N'Kỹ thuật cài đặt bộ nhớ ảo nào sau đây cho phép các trang của tiến trình chỉ được nạp vào bộ nhớ chính khi được yêu cầu?','005','Dynamic loading','Dynamic linking','Demand paging','Frame allocation','C')
INSERT INTO CauHoi VALUES (N'Trong giải thuật thay trang LRU, trang được chọn để thay thế có đặc điểm gì?','005',N'Trang nhớ có thời điểm tham chiếu nhỏ nhất',N'Trang nhớ được tham chiếu trễ nhất trong tương lai',N'Trang nhớ đầu tiên được nạp vào hệ thống',N'Trang nhớ vừa được thay thế gần đây nhất','A')
INSERT INTO CauHoi VALUES (N'“Không cho phép (ít nhất) một trong 4 điều kiện cần cho deadlock” là đặc điểm của phương pháp giải quyết deadlock nào?','005',N'Tránh deadlock',N'Ngăn deadlock',N'Bỏ qua deadlock',N'Phát hiện deadlock và phục hồi hệ thống','B')
INSERT INTO CauHoi VALUES (N'Địa chỉ lệnh và dữ liệu có thể được chuyển đổi thành địa chỉ thực tại thời điểm biên dịch nếu thỏa mãn điều kiện nào?','005',N'Địa chỉ nạp chương trình (trong bộ nhớ) phải được biết trước',N'Kích thước chương trình phải được biết trước',N'Bộ nhớ phải được chia thành các phân vùng có kích thước bằng nhau',N'Trong quá trình thực thi, tiến trình chỉcó thể di chuyển trên một tập các trang nhớ cho trước','A')
INSERT INTO CauHoi VALUES (N'Lựa chọn nào dưới đây KHÔNG phải là một mô hình đa tiểu trình?','005','Many-to-One','One-to-One','Many-to-Many','One-to-Many','D')
INSERT INTO CauHoi VALUES (N'Tiến trình ở trạng thái terminated khi nào?','005',N'Tiến trình vừa được tạo',N'Tiến trình đã có đủ tài nguyên, chỉ còn cần CPU',N'Tiến trình đã kết thúc',N'Các lệnh của tiến trình đang được thực thi','C')
INSERT INTO CauHoi VALUES (N'Kiểu cấu trúc hệ điều hành nào là sự kết hợp nhiều cách tiếp cận để giải quyết các nhu cầu về hiệu suất, bảo mật, nhu cầu sử dụng?','005',N'Cấu trúc modules',N'Cấu trúc phân lớp (layer)',N'Cấu trúc vi nhân',N'Cấu trúc lai (hybrid)','D')
INSERT INTO CauHoi VALUES (N'Kiểu cấu trúc hệ điều hành nào sử dụng cách tiếp cận hướng đối tượng với mỗi core thành phần là tách biệt nhau?','005',N'Cấu trúc modules',N'Cấu trúc phân lớp (layer)',N'Cấu trúc vi nhân',N'Cấu trúc Monolithic','A')
INSERT INTO CauHoi VALUES (N'Trong tiến trình đa luồng, các tiểu trình KHÔNG chia sẻ chung thành phần nào dưới đây?','005','Code','Data','Registers','Resources (files)','A')
INSERT INTO CauHoi VALUES (N'Khi một tiến trình được nạp vào bộ nhớ, các biến cục bộ của nó được chứa ở đâu?','005','Stack section','Data section','Text section','Heap section','C')
INSERT INTO CauHoi VALUES (N'Lời gọi hệ thống chủ yếu được truy cập thông qua phương tiện nào?','005','Graphics User Interface','Command Line Interface','Application Programming Interface','Command Line Interpreter','C')
INSERT INTO CauHoi VALUES (N'Cơ chế kết khối có thể được sử dụng để giải quyết vấn đề nào dưới đây?','005',N'Phân mảnh ngoại',N'Phân mảnh nội',N'Lỗi trang',N'Các trang nhớ bị hoán chuyển vào ra liên tục','A')
INSERT INTO CauHoi VALUES (N'Đoạn mã chứa các thao tác lên dữ liệu chia sẻ trong mỗi tiến trình được gọi là gì?','005',N'Vùng tranh chấp',N'Loại trừ tương hỗ',N'Deadlock',N'Chuỗi an toàn','A')
INSERT INTO CauHoi VALUES (N'Đặc điểm chung của nhóm giải pháp đồng bộ “Sleep & Wakeup” là gì?','005',N'Tiến trình tiếp tục tiêu thụCPU khi chưa được vào vùng tranh chấp',N'Cần có sự hỗ trợ của hệ điều hành',N'Cần có sự hỗ trợ của phần cứng',N'Không bao giờ xảy ra tình trạng đói tài nguyên','B')
INSERT INTO CauHoi VALUES (N'Nếu bảng phân trang được lưu giữ trong bộ nhớ chính thì kích thước của nó sẽ được xác định bởi thành phần nào?','005','TLBs',N'Thanh ghi page-table length',N'Thanh ghi page-table base',N'Số bit dùng để biểu diễn không gian địa chỉ','B')
INSERT INTO CauHoi VALUES (N'Trong hệ thống máy tính, người dùng phát lệnh cho Hệ điều hành thực thi thông qua lớp nào?','005','Shell','Driver','Kernel','Hardware','A')

select * from CauHoi 
=======
﻿CREATE DATABASE FTM 
GO
USE [FTM]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Mon
(
MAMON INT NOT NULL PRIMARY KEY,
TEN NVARCHAR(50),
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE CauHoi
(
 NOIDUNG NVARCHAR(3000) NOT NULL,
 MAMON INT NOT NULL, 
 DA1 NVARCHAR(3000),
 DA2 NVARCHAR(3000),
 DA3 NVARCHAR(3000),
 DA4 NVARCHAR(3000),
 DA CHAR NOT NULL,
)
GO
ALTER TABLE CauHoi 
ADD CONSTRAINT FK_CH_M_MAMON FOREIGN KEY (MAMON) REFERENCES Mon(MAMON)

INSERT INTO Mon VALUES ('001',N'Nhập môn lập trình')
INSERT INTO Mon VALUES ('002', N'Lập trình hướng đối tượng')
INSERT INTO Mon VALUES ('003',N'Cấu trúc dữ liệu và giải thuật')
INSERT INTO Mon VALUES ('004', N'Nhập môn mạng máy tính')
INSERT INTO Mon VALUES ('005', N'Hệ điều hành')



INSERT INTO CauHoi VALUES (N'Độ ưu tiên đúng đối với các toán tử logic là:','001','AND, NOT, OR', 'NOT, OR, AND','OR, NOT, AND','NOT, AND, OR','D')
INSERT INTO CauHoi VALUES (N'Sử dụng khai báo “double a[12]”, phần tử a[7] là phần tử thứ bao nhiêu trong mảng a:', '001','6','7','8','9', 'C')
INSERT INTO CauHoi VALUES (N'Phép trừ 1 con trỏ với một số nguyên sẽ là: ','001', N'Một số nguyên', N'Một con trỏ cùng kiểu',N'Cả hai đều đúng',N'Đáp án khác','B')
INSERT INTO CauHoi VALUES (N'Kích thước của biến con trỏ là: ','001', '2 byte','1 byte', '4 byte', '3 byte', 'A')
INSERT INTO CauHoi VALUES (N'Giá trị logic của biểu thức sau là gì: !(1&&1||1&&0): ', '001', '1', '0','-1', 'Lỗi','B')


INSERT INTO CauHoi VALUES (N'Trừu tượng hóa là: ', '002', N'Phương pháp quan tâm đến mọi chi tiết của đối tượng.',N'Phương pháp chỉ quan tâm đến những chi tiết cần thiết (chi tiết chính) và bỏ qua những chi tiết không cần thiết.',N'Phương pháp thay thế những chi tiết chính bằng những chi tiết tương tự.',N'Không có đáp án đúng','B')
INSERT INTO CauHoi VALUES (N'Khi khai báo thành phần thuộc tính và phương thức của lớp , nếu không khai báo từ khóa private,  public, hay protected thì mặc định sẽ là:','002','private', 'public', 'protected',N'Lỗi, cần khai báo 1 trong 3','A')
INSERT INTO CauHoi VALUES (N'Từ khóa nào sau đây được dùng khi lớp con muốn cài lại phương thức được thừa kế từ lớp cha: ','002','New', 'Virtual','Override','Abstract','C') 
INSERT INTO CauHoi VALUES (N'OOP là viết tắt của: ', '002','Object Open Programming', 'Object Oriented Programming', 'Object Oriented Proccessing','Open Object Programming', 'B')
INSERT INTO CauHoi VALUES (N'Đặc điểm của Tính đa hình?', '002', N'Khả năng một hàm, thủ tục có thể được kế thừa lại', N'Khả năng một thông điệp có thể được truyền lại cho lớp con của nó',N'Khả năng một hàm, thủ tục được sử dụng lại',N'Khả năng một thông điệp có thể thay đổi cách thể hiện của nó theo lớp cụ thể của đối tượng được nhận thông điệp','D')

INSERT INTO CauHoi VALUES (N'Thao tác POP(x) dùng trong Stack là để:', '003', N'Xóa bỏ một phần tử bất kì khỏi Stack', N'Xóa bỏ một dãy các phần tử ra khỏi Stack', N'Lấy phần tử đầu tiên ra khỏi Stack', N'Lấy một phần tử cuối cùng ra khỏi đỉnh Stack', 'D')
INSERT INTO CauHoi VALUES (N'Thao tác Push(x) dùng trong Stack là để:','003',N'Bổ sung một dãy các phần tử vào đỉnh Stack',N'Bổ sung một phần tử bất kì vào Stack',N'Bổ sung một phần tử vào đỉnh Stack',N'Bổ sung một phần tử vào đầu Stack','C')
INSERT INTO CauHoi VALUES (N'Cho Stack gồm 5 phần tử {12, 5, 20, 23, 25}, trong đó 25 là phần tử ở đỉnh Stack. Để lấy ra phần tử thứ 4 trong Stack ta phải làm thế nào?', '003','POP(25),POP(23), PUSH(25)','POP(23),PUSH(25)','POP(25),PUSH(23)','POP(25),POP(23)','A')
INSERT INTO CauHoi VALUES (N'Trong biểu diễn dữ liệu dưới dạng cây, cấp của cây chính: ','003',N'Tổng số nút trên cây',N'Cấp cao nhất của nút gốc', N'Cấp cao nhất của nút lá',N'Cấp cao nhất của một nút trên cây','D')
INSERT INTO CauHoi VALUES (N'Trong các giải thuật sắp xếp, giải thuật nào áp dụng phương pháp "Chia để trị"?', '003', N'Quick sort, Heap sort', 'Quick sort, Insert sort', 'Quick sort, Merge sort', 'Quick sort, Bubble sort', 'C')
INSERT INTO CauHoi VALUES (N'Hàng đợi còn được gọi là danh sách kiểu: ','003','LIFO','FILO','LOLO','FIFO','D')
INSERT INTO CauHoi VALUES (N'Ý tưởng phương pháp sắp xếp nổi bọt (bubble sort) là: ','003',N'So sánh hai phần tử kề nhau nếu chưa đúng thì đổi chỗ',N'Dựa vào tư tưởng "chia để trị"',N'Chọn phần tử bé nhất xếp vào vị trí thứ nhất,tương tự đối với phần tử nhỏ thứ hai,ba...',N'Lần lượt lấy phần tử của danh sách chèn vị trí thích hợp của danh sách đã sắp','A')

INSERT INTO CauHoi VALUES (N'Giao thức nào thuộc tầng Application?','004','TCP','HTTP','NFS','IP','B')
INSERT INTO CauHoi VALUES (N'Địa chỉ IPv6 gồm bao nhiêu bit', '004','32','48','64','128','D')
INSERT INTO CauHoi VALUES (N'TCP làm việc ở lớp nào của mô hình OSI?','004','Layer 4','Layer 5','Layer 6','Layer 7','A')
INSERT INTO CauHoi VALUES (N'Để kết nối Router với Router ta dùng:','004',N'Cáp chéo (Cross-Cable)',N'Cáp thẳng (Straight Cable)','Rollover Cable',N'Tất cả đều sai','A')
INSERT INTO CauHoi VALUES (N'Lệnh nào sau đây cho biết địa chỉ IP của máy tính:','004','IP','IPCONFIG','FTP','TCP_IP','B')
INSERT INTO CauHoi VALUES (N'Checksum trong gói dữ liệu UDP có độ dài:','004','4 bit','8 bit', '16 bit','32 bit', 'B')
INSERT INTO CauHoi VALUES (N'SMTP sử dụng cổng số bao nhiêu:','004','143','25','80','225','B')
INSERT INTO CauHoi VALUES (N'Phản hồi nào cho biết client đang yêu cầu thông điệp không tồn tại trên máy chủ?','004','200 OK','400 Bad Request','301 Moved Permanently','404 Not Found','D')
INSERT INTO CauHoi VALUES (N'Các đơn vị dữ liệu giao thức trong mô hình OSI được gọi là:','004','UDP','OSI','PDU','Packet','C')
INSERT INTO CauHoi VALUES (N'Trong giao thức HTTP, phương thức nào được sử dụng để yêu cầu dữ liệu từ máy chủ?','004','GET','POST','PUT','DELETE','A')
INSERT INTO CauHoi VALUES (N'Trong giao thức DNS, bản ghi nào được sử dụng để ánh xạ tên miền thành địa chỉ IP?','004','A','CNAME','MX','PTR','A')
INSERT INTO CauHoi VALUES (N'RDT sử dụng cơ chế nào để đồng bộ hóa quá trình truyền tin giữa người gửi và người nhận?','004','Go-Back-N','Selective Repeat','Stop-and-Wait','Piggybacking','C')
INSERT INTO CauHoi VALUES (N'Thứ tự đúng từ trên xuống dưới trong mô hình chồng giao thức Internet phân tầng','004','Application – Transport – Network – Physical – Link','Physical – Link – Network – Transport - Application',' Application – Network – Transport – Link - Physical
','Application – Transport – Network – Link – Physical','D')

INSERT INTO CauHoi VALUES (N'Chọn phát biểu SAI về các tác vụ đối với tiến trình?','005',N' Tiến trình con nhận tài nguyên từ hệ điều hành hoặc từ tiến trình cha.',N'Không gian địa chỉ của tiến trình con luôn được nhân bản từ tiến trình cha.',N'Tiến trình có thể tự kết thúc hoặc bị kết thúc bởi tiến trình khác.',N'Tiến trình con chỉ có thể sử dụng một phần hoặc toàn bộ tài nguyên của tiến trình cha','B')
INSERT INTO CauHoi VALUES (N'Chọn phát biểu ĐÚNG về cơ chế phân trang?','005',N'Bộ nhớ vật lý được chia thành các khung trang còn bộ nhớ luận lý được chia thành các trang',N' Hệ điều hành tạo một bảng phân trang cho tất cả các tiến trình',N'Thanh ghi page-table length (PTLR) xác định vị trí của bảng phân trang',N'Kích thước của bảng phân trang được xác định bởi thanh ghi page-table base (PTBR)','A')
INSERT INTO CauHoi VALUES (N'Các giải pháp đồng bộ được chia thành những nhóm nào?','005','Busy Waiting – Sleep & Wakeup','Busy Waiting –Circular Wait','Sleep & Wakeup – Hold & Wait','Sleep & Wakeup – Mutual Exclusion','A')
INSERT INTO CauHoi VALUES (N'Chọn phát biểu SAI trong các phát biểu sau?','005',N'Nếu hệ thống đang ở trạng thái an toàn thì tồn tại ít nhất một chuỗi thứ tự an toàn trong hệ thống',N'Nếu đồ thị cấp phát tài nguyên có chu trình thì có deadlock xảy ra',N'Nếu hệ thống đang ở trạng thái không an toàn thì có thể xảy ra deadlock',N'Một tiến trình gọi là deadlock nếu nó đang đợi một sự kiện mà sẽ không bao giờ xảy ra','B')
INSERT INTO CauHoi VALUES (N'Kỹ thuật cài đặt bộ nhớ ảo nào sau đây cho phép các trang của tiến trình chỉ được nạp vào bộ nhớ chính khi được yêu cầu?','005','Dynamic loading','Dynamic linking','Demand paging','Frame allocation','C')
INSERT INTO CauHoi VALUES (N'Trong giải thuật thay trang LRU, trang được chọn để thay thế có đặc điểm gì?','005',N'Trang nhớ có thời điểm tham chiếu nhỏ nhất',N'Trang nhớ được tham chiếu trễ nhất trong tương lai',N'Trang nhớ đầu tiên được nạp vào hệ thống',N'Trang nhớ vừa được thay thế gần đây nhất','A')
INSERT INTO CauHoi VALUES (N'“Không cho phép (ít nhất) một trong 4 điều kiện cần cho deadlock” là đặc điểm của phương pháp giải quyết deadlock nào?','005',N'Tránh deadlock',N'Ngăn deadlock',N'Bỏ qua deadlock',N'Phát hiện deadlock và phục hồi hệ thống','B')
INSERT INTO CauHoi VALUES (N'Địa chỉ lệnh và dữ liệu có thể được chuyển đổi thành địa chỉ thực tại thời điểm biên dịch nếu thỏa mãn điều kiện nào?','005',N'Địa chỉ nạp chương trình (trong bộ nhớ) phải được biết trước',N'Kích thước chương trình phải được biết trước',N'Bộ nhớ phải được chia thành các phân vùng có kích thước bằng nhau',N'Trong quá trình thực thi, tiến trình chỉcó thể di chuyển trên một tập các trang nhớ cho trước','A')
INSERT INTO CauHoi VALUES (N'Lựa chọn nào dưới đây KHÔNG phải là một mô hình đa tiểu trình?','005','Many-to-One','One-to-One','Many-to-Many','One-to-Many','D')
INSERT INTO CauHoi VALUES (N'Tiến trình ở trạng thái terminated khi nào?','005',N'Tiến trình vừa được tạo',N'Tiến trình đã có đủ tài nguyên, chỉ còn cần CPU',N'Tiến trình đã kết thúc',N'Các lệnh của tiến trình đang được thực thi','C')
INSERT INTO CauHoi VALUES (N'Kiểu cấu trúc hệ điều hành nào là sự kết hợp nhiều cách tiếp cận để giải quyết các nhu cầu về hiệu suất, bảo mật, nhu cầu sử dụng?','005',N'Cấu trúc modules',N'Cấu trúc phân lớp (layer)',N'Cấu trúc vi nhân',N'Cấu trúc lai (hybrid)','D')
INSERT INTO CauHoi VALUES (N'Kiểu cấu trúc hệ điều hành nào sử dụng cách tiếp cận hướng đối tượng với mỗi core thành phần là tách biệt nhau?','005',N'Cấu trúc modules',N'Cấu trúc phân lớp (layer)',N'Cấu trúc vi nhân',N'Cấu trúc Monolithic','A')
INSERT INTO CauHoi VALUES (N'Trong tiến trình đa luồng, các tiểu trình KHÔNG chia sẻ chung thành phần nào dưới đây?','005','Code','Data','Registers','Resources (files)','A')
INSERT INTO CauHoi VALUES (N'Khi một tiến trình được nạp vào bộ nhớ, các biến cục bộ của nó được chứa ở đâu?','005','Stack section','Data section','Text section','Heap section','C')
INSERT INTO CauHoi VALUES (N'Lời gọi hệ thống chủ yếu được truy cập thông qua phương tiện nào?','005','Graphics User Interface','Command Line Interface','Application Programming Interface','Command Line Interpreter','C')
INSERT INTO CauHoi VALUES (N'Cơ chế kết khối có thể được sử dụng để giải quyết vấn đề nào dưới đây?','005',N'Phân mảnh ngoại',N'Phân mảnh nội',N'Lỗi trang',N'Các trang nhớ bị hoán chuyển vào ra liên tục','A')
INSERT INTO CauHoi VALUES (N'Đoạn mã chứa các thao tác lên dữ liệu chia sẻ trong mỗi tiến trình được gọi là gì?','005',N'Vùng tranh chấp',N'Loại trừ tương hỗ',N'Deadlock',N'Chuỗi an toàn','A')
INSERT INTO CauHoi VALUES (N'Đặc điểm chung của nhóm giải pháp đồng bộ “Sleep & Wakeup” là gì?','005',N'Tiến trình tiếp tục tiêu thụCPU khi chưa được vào vùng tranh chấp',N'Cần có sự hỗ trợ của hệ điều hành',N'Cần có sự hỗ trợ của phần cứng',N'Không bao giờ xảy ra tình trạng đói tài nguyên','B')
INSERT INTO CauHoi VALUES (N'Nếu bảng phân trang được lưu giữ trong bộ nhớ chính thì kích thước của nó sẽ được xác định bởi thành phần nào?','005','TLBs',N'Thanh ghi page-table length',N'Thanh ghi page-table base',N'Số bit dùng để biểu diễn không gian địa chỉ','B')
INSERT INTO CauHoi VALUES (N'Trong hệ thống máy tính, người dùng phát lệnh cho Hệ điều hành thực thi thông qua lớp nào?','005','Shell','Driver','Kernel','Hardware','A')

select * from CauHoi 
>>>>>>> 061aa2bb68e35f8f1ca9690b87dcf623e192f233:PikachuGame/GameMario/CSDL game mario/cauhoi_data.sql
Where MAMON = 1