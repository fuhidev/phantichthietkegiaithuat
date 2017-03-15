# phantichthietkegiaithuat
Môn Phân tích thiết kế giải thuật trường Đại học Tôn Đức Thắng - mùa Xuân 20116

Trong cả hai bài tập lớn các Bạn sẽ thiết kế và phân tích giải thuật để giải quyết các vấn đề khác nhau. Các Bạn trình bày hai bài tập lớn của mình ở dạng một bài luận ngắn. Mỗi vấn đề là một chương trong bài. Nội dung của mỗi chương như sau:
1. Trình bày tóm tắt vấn đề cần giải quyết.
2. Mô tả giải thuật giải quyết vấn đề bằng ngôn ngữ tự nhiên kết hợp các ký hiệu toán học và mã giả. 
3. Đưa ra các ví dụ cụ thể của vấn đề và
+ các bước giải quyết vấn đề sử dụng giải thuật được mô tả
+ cài đặt giải thuật giải quyết vấn đề cụ thể sử dụng một ngôn ngữ lập trình (C++, C#, Java, Python, MATLAB, R)  
4. Phân tích thời gian chạy của giải thuật.
Bài làm của các Bạn còn được đánh giá điểm trình bày. Trong đó, các Bạn phải diễn giải ngắn gọn, xúc tích các câu hỏi. Những câu hỏi cần chứng minh thì Sinh Viên phải chứng minh bằng toán học. Những dữ liệu thực nghiệm cần biểu đồ thể hiện, các Bạn phải vẽ biểu đồ.Điểm tối đa chỉ dành cho các bạn có nội dung bài làm được trình bày rõ ràng. Chương trình cài đặt cũng được đưa vào bài luận file (.doc), đồng thời các Bạn lưu mã nguồn đầy đủ tuân theo Coding Convention của ngôn ngữ lập trình, có chú thích Code ở dạng đĩa CD
Tất cả bài làm được đặt trong cùng một thư mục đặt tên là HoTen_MSSV. Sau đó các Bạn nén thư mục đó và gửi file nén lên Sakai trước deadline. Đồng thời, mỗi Sinh Viên gửi một bản in (kèm đĩa CD ghi mã nguồn và file .doc/.docx) nộp đến GV hướng dẫn thực hành để làm minh chứng với nhà trường. SV thiếu một trong hai khâu nộp bài sẽ được ĐÌNH CHỈ THI CUỐI KỲ.
DEADLINE: 20.04.2016.
Số lần được nộp bài trên Sakai: 3 (tất cả nén lại một file họ tên MSSV).
Số lần nộp bài trực tiếp (bản in + CD): sẽ thông báo sau
Bài tập lớn 1
1.1 Cho các giải thuật tìm kiếm sau:
Insertion Sort
Selection sort
Bubble sort
Merge Sort
Quick Sort
Yêu cầu thiết kế, cài đặt và phân tích thời gian chạy các giải thuật trên
So sánh thời gian chạy bằng công cụ Big-O và thời gian chạy thực tế. Giải thích nguyên nhân sự khác nhau của các giải thuật có cùng Big-O nhưng thời gian chạy thực tế khác nhau.
1.2 Cho các giải thuật, cấu trúc dữ liệu sau:
Tìm kiếm tuần tự (Sequential Search)
Tìm kiếm nhị phân (Binary Search)
Cây nhị phân tìm kiếm (Binary Search Tree)
Yêu cầu thiết kế, cài đặt và phân tích thời gian chạy các giải thuật, cấu trúc dữ liệu trên.

Bài tập lớn 2
2.1 (a) Giả sử Bạn sở hữu một dải đất có dạng của một vòng tròn, và muốn bán nó đến 
 khách hàng. Mỗi một khách hàng quan tâm đến một phân đoạn tiếp giáp trên chu vi (tức là. Một vòng cung), có thể được đại diện trong tọa độ cực. Ví dụ, khách hàng  muốn có đến trên đường tròn. Thật không may, nhiều người muốn có các khoản đất chồng lên nhau. Bạn hãy đề xuất một thuật toán để tối đa hóa số lượng yêu cầu của khách hàng mà bạn có thể đáp ứng.
(b) Đây là thời buổi kinh tế thị trường tự do và cạnh tranh. Vì vậy, ngoài việc mỗi khách hàng chọn một vòng cung mà họ muốn, họ còn đề nghị một mức giá nữa. Bạn hãy đề xuất một thuật toán để tối đa hóa số tiền mà Bạn có thể kiếm được.
2.2 Bạn muốn bán ngôi nhà của bạn, nhưng có rất ít người mua do sự thị trường đóng băng. Giả sử rằng tại bất kỳ thời gian nhất định có ít nhất một người mua quan tâm đến ngôi nhà của bạn. Bạn biết chắc chắn rằng phạm vi của đề nghị từ bất kỳ người mua sẽ có từ 1 đến M (trăm triệu đồng). Sau khi nhận được một đề nghị từ mỗi người mua, bạn thực hiện một quyết định hoặc bán cho người ta hoặc từ chối bán. Nếu bạn không bán, người mua sẽ mua nhà khác, và bạn sẽ mất đi cơ hội bán nhà cho người ấy mãi mãi. Lưu ý rằng danh sách người mua là hữu hạn, và bạn không biết có bao nhiêu người muốn mua nhà bạn. Nếu bạn từ chối tất cả các lời đề nghị, bạn sẽ phải bán nhà cho ngân hàng với giá 1 trăm triệu đồng. Nhưng bạn muốn bán nhà mình với giá cao nhất có thể. Bạn muốn tối đa hóa lợi nhuận từ việc bán ngôi nhà của bạn. Lưu ý rằng một thuật toán tối ưu sẽ luôn luôn chọn được lời đề nghị tốt nhất.
(a) Đề xuất một thuật toán tất định (deterministic algorithm) cho vấn đề trên. Với bất kỳ danh sách đề nghị nào, trong đó x là lời đề nghị tốt nhất, thuật toán của bạn luôn chọn được lời đề nghị có giá trị không ít hơn  (trăm triệu đồng).
(b) Đề xuất một thuật toán ngẫu nhiên (randomized algorithm) cho vấn đề trên. Với bất kỳ danh sách đề nghị nào, trong đó x là lời đề nghị tốt nhất, thuật toán của bạn luôn chọn được lời đề nghị có giá trị không ít hơn  (trăm triệu đồng).
