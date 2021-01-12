# C-project
sử dụng database:
1/ mở project
2/ mở SQL management studio, execute 3 file .sql trong project 
(data.sql --> tạo database+table ; Add_data.sql --> thêm dữ liêu vô table ; Userproc...sql --> tạo userproc)
3/ chọn tool>connect to database
4/ chọn "Microsoft SQL Server"
5/ Sever name xem trong object explorer trong SSMS dòng đầu tiên.
6/ chọn database name : RestaurantManagement
7/ chọn test connection
8/ chọn advanced, copy cái dòng text bên trên nút OK
9/ trong project mở DataProvider.cs (thư mục DAO), paste cái text vừa copy vô connectionStr
