use FastFoodApp
go

insert into DanhMuc(TenDanhMuc,ImgDM,moTa) values (N'Tất cả','https://imgur.com/mX0VUay.png',N'Tất cả')


update DanhMuc set ImgDM = 'https://imgur.com/xAi8SJw.png' where IDDanhMuc = 'DM005'
select * from SHOP

update SHOP set ImgShop = 'https://imgur.com/VTnGPdq.png' where IDShop = 'SH002'


exec addDanhMuc N'Tất cả','https://imgur.com/mX0VUay.png',N'Tất cả'
exec addDanhMuc N'Hamburger','https://imgur.com/iALvP7s.jpg',N'Hamburger'
exec addDanhMuc N'Pizza','https://imgur.com/gs0Ltjz.jpg',N'Pizza các loại'
exec addDanhMuc N'Nước uống','https://imgur.com/U1r5IH8.jpg',N'Nước uống'
exec addDanhMuc N'Gà rán','https://imgur.com/coR4e7c.jpg',N'Gà rán'

exec addDanhMuc N'Kem','https://imgur.com/d876Y0c.png',N'Kem'
exec addDanhMuc N'Khoai tây','https://imgur.com/zTbHU4i.png',N'Khoai tây'


exec addSanPham N'Pizza hải sản', 'DM003', 'SH001',150000,20,'https://bears.vn/wp-content/uploads/2019/08/4-2.jpg'
exec addSanPham N'Pizza phô mai', 'DM003', 'SH001',160000,20,'https://bears.vn/wp-content/uploads/2019/08/5-1.jpg'
exec addSanPham N'Pizza bò', 'DM003', 'SH001',200000,20,'https://bears.vn/wp-content/uploads/2019/08/6-1.jpg'
exec addSanPham N'Pizza xúc xích', 'DM003', 'SH001',140000,20,'https://bears.vn/wp-content/uploads/2019/08/7-1.jpg'

exec addSanPham N'Burger Mozzarella', 'DM002', 'SH002',58000,20,'https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/b/u/burger-534x374px_mozzarella-burger.png'
exec addSanPham N'Burger Double Double', 'DM002', 'SH002',59000,20,'https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/1e747a0edfedb1f60dd6ec5ad21ff8df/b/u/burger-534x374px_ddouble-burger.png'
exec addSanPham N'Burger Tôm', 'DM002', 'SH002',49000,20,'https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/b/u/burger-534x374px_shrimp-burger.png'
exec addSanPham N'Burger Gà Thượng Hải', 'DM002', 'SH002',43000,20,'https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/b/u/burger-534x374px_chicken-burger.png'

select * from SHOP
delete DanhMuc where IDDanhMuc = 'DM015'
select * from NguoiDung

update SanPham set DanhGia = 4 where IDDanhMuc = 'DM003'

alter table SanPham add moTaSP NVARCHAR(300)

Insert into HinhAnh(imgUrl,IDSP) values ('https://cdn.tgdd.vn/2020/09/CookProduct/1200bzhspm-1200x676.jpg','SP001')
Insert into HinhAnh(imgUrl,IDSP) values ('https://cdn.tgdd.vn/2020/08/CookProduct/Untitled-1-1200x676-41.jpg','SP001')
Insert into HinhAnh(imgUrl,IDSP) values ('https://static.riviu.co/960/image/2019/09/22/b284bf606e88c531674cd9c11d932695_output.jpeg','SP001')


Insert into HinhAnh(imgUrl,IDSP) values ('https://cdn.tgdd.vn/Files/2021/08/24/1377468/cach-lam-pizza-pho-mai-bap-ngot-beo-ngay-don-gian-tai-nha-202108241432283228.jpg','SP002')
Insert into HinhAnh(imgUrl,IDSP) values ('https://pizzaparadise.vn/wp-content/uploads/Pizza-ph%C3%B4-mai.jpg','SP002')
Insert into HinhAnh(imgUrl,IDSP) values ('https://quanghuyplaza.vn/wp-content/uploads/2022/01/1-pho-mai-lam-pizza-mua-o-dau.jpg','SP002')

Insert into HinhAnh(imgUrl,IDSP) values ('https://media.cooky.vn/recipe/g1/7403/s640/recipe7403-635938188256947072.jpg','SP003')
Insert into HinhAnh(imgUrl,IDSP) values ('https://monngon.tv/wp-content/uploads/2020/09/fd0aae61e2cc236b91d91ef0d28daff9-cach-lam-banh-pizza-s.jpg','SP003')
Insert into HinhAnh(imgUrl,IDSP) values ('https://pepsiworld.com.vn/wp-content/uploads/2018/06/cach-lam-banh-pizza-bo_2.jpg','SP003')

Insert into HinhAnh(imgUrl,IDSP) values ('https://www.huongnghiepaau.com/wp-content/uploads/2019/04/banh-pizza-thom-ngon.jpg','SP004')
Insert into HinhAnh(imgUrl,IDSP) values ('https://www.hocvienamthuc.com/wp-content/uploads/2021/07/cach-lam-banh-pizza-xuc-xich-pho-mai-beo-ngay-tai-nha.jpg','SP004')
Insert into HinhAnh(imgUrl,IDSP) values ('https://doiduavang.vn/wp-content/uploads/2021/01/pizza-nhan-xuc-xich-doi-dua-vang-scaled-e1611801412805.jpg','SP004')

Insert into HinhAnh(imgUrl,IDSP) values ('https://galbanicheese.com/wp-content/uploads/2019/09/Fresh-Mozzarella-Burger-72DPI-e1476292751473_resize-800x600.jpg','SP005')
Insert into HinhAnh(imgUrl,IDSP) values ('https://static.riviu.co/960/image/2020/06/24/423e006a78f8d5126f6bf7e9e92957b4_output.jpeg','SP005')
Insert into HinhAnh(imgUrl,IDSP) values ('https://static.riviu.co/960/image/2020/06/24/2350e8daeff9cc300d0cd6cc89e884b2_output.jpeg','SP005')

Insert into HinhAnh(imgUrl,IDSP) values ('https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/1e747a0edfedb1f60dd6ec5ad21ff8df/b/u/burger-534x374px_ddouble-burger.png','SP006')
Insert into HinhAnh(imgUrl,IDSP) values ('https://www.agaburger.com.tr/wp-content/uploads/2021/01/double-1.jpg','SP006')
Insert into HinhAnh(imgUrl,IDSP) values ('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT3qWrA6ALEuReD30WhkfWWBUlnv2hzY2o_7OPH3VN9U24GQSC593WAV6jM-hRw0-iV6WE&usqp=CAU','SP006')

Insert into HinhAnh(imgUrl,IDSP) values ('https://popeyes.vn/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/t/o/tom.png','SP007')
Insert into HinhAnh(imgUrl,IDSP) values ('https://chianui.vn/wp-content/uploads/2019/05/burger-tom-cua.jpg','SP007')
Insert into HinhAnh(imgUrl,IDSP) values ('https://product.hstatic.net/1000242782/product/burger_tom_e571306016d34d14a72558d7ea8b4a2d_master.jpg','SP007')


Insert into HinhAnh(imgUrl,IDSP) values ('https://product.hstatic.net/1000242782/product/burrger_ga_nam_f905c8d6e2ed4228afec3411eaa68437_master.jpg','SP008')
Insert into HinhAnh(imgUrl,IDSP) values ('https://chianui.vn/wp-content/uploads/2019/05/burger-tom-cua.jpg','SP008')
Insert into HinhAnh(imgUrl,IDSP) values ('https://product.hstatic.net/1000242782/product/burger_tom_e571306016d34d14a72558d7ea8b4a2d_master.jpg','SP008')


select * from ChiTietDonHang
Delete HinhAnh

select * from SanPham
delete SanPham


insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Ten','DM001','IDSHOP','5','Gía','50','link ảnh','Mô tả')


update SanPham set moTaSP = N'Thành phần: Bột mỳ, phomai, nước, xúc xích (≥ 3 %), hành tây, ngô ngọt, ớt chuông, tương cà (< 5 %), bơ (< 5 %), dầu ăn, đường kính, men bánh (< 5 %), muối ăn.' where IDSP = 'SP004'


insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Kem Socola','DM006','SH001','5','12000','50','https://i.imgur.com/ZGTqW3V.png',N'Kem sô cô la là kem với hương vị sô cô la tự nhiên hoặc nhân tạo. Sô cô la là hương vị phổ biến thứ hai ở Mỹ, sau vani.')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM TƯƠI DÂU VÀ SOCOLA','DM006','SH001','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_600x400/kem-tuoi-dau-va-socola-1595948153.png',N'Socola (20%). Puree dâu (10,35%). Dầu dừa. Đường tinh luyện. Bơ Ancher. Sữa bột gầy Glucose syrup. Phụ gia thực phẩm excelai 8802. Hương liệu tổng hợp: hương vani, hương sữa, hương dừa. Nước sạch')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM TƯƠI VANI VÀ TRÀ XANH','DM006','SH001','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_600x400/kem-tuoi-vani-va-tra-xanh-1595948146.png',N' Hương trà xanh, hương vani, hương sữa, hương dừa.')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM TƯƠI VANI','DM006','SH002','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_600x400/kem-tuoi-vani-1595948136.png',N' Đường, sữa đặc, trứng, hương liệu... ')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM TƯƠI TRÀ XANH','DM006','SH002','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_600x400/kem-tuoi-tra-xanh-1595948131.png',N' Hương trà xanh, hương vani, hương sữa, hương dừa.')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM TƯƠI DƯA LƯỚI','DM006','SH002','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_800x0/kem-tuoi-dua-luoi-1595948110.png',N' Hương liệu tổng hợp: hương vani, hương sữa, Nước sạch.')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM TƯƠI SOCOLA','DM006','SH001','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_800x0/kem-tuoi-socola-1595948117.png',N'Hương liệu tổng hợp: hương vani, hương sữa, hương dừa. Nước sạch')


insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM TƯƠI DÂU','DM006','SH001','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_800x0/kem-tuoi-dau-1595948123.png',N'Hương liệu tổng hợp: hương vani, hương sữa, Nước sạch.')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM ỐC QUẾ KHOAI MÔN','DM006','SH001','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_800x0/kem-oc-que-khoai-mon-1595500763.png',N'Khoai môn, đường, sữa đặc, sữa bột bèo, nước cốt dừa, hương liệu...')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM ỐC QUẾ VANI','DM006','SH001','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_800x0/kem-oc-que-vani-1595500768.png',N'Đường, sữa đặc, trứng, hương liệu.')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM ỐC QUẾ CỐM','DM006','SH001','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_800x0/kem-oc-que-com-1595500784.png',N'Cốm, đường, sữa đặc, sữa bột béo, hương liệu... ')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'KEM ỐC QUẾ CACAO','DM006','SH001','5','12000','50','https://kemtrangtien.vn/upload/product/thumb_800x0/kem-oc-que-cacao-1595500804.png',N'Cacao, đường, trứng, sữa đặc, sữa bột béo, hương liệu ')

---
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Khoai tây tắm phô mai thịt xông khói','DM007','SH001','5','45000','50','https://burgerking.vn/media/catalog/product/cache/1/small_image/1000x/9df78eab33525d08d6e5fb8d27136e95/k/h/khoai-t_y-chi_n-t_m-ph_-mai-v_i-th_t-x_ng-kh_i.jpg',N'Khoai tây tắm phô mai thịt xông khói')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Khoai tây tắm phô mai','DM007','SH002','5','32000','50','https://burgerking.vn/media/catalog/product/cache/1/small_image/1000x/9df78eab33525d08d6e5fb8d27136e95/k/h/khoai-t_y-chi_n-t_m-ph_-mai.jpg',N'Khoai tây tắm phô mai')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Khoai tây chiên size s','DM007','SH002','5','17000','50','https://burgerking.vn/media/catalog/product/cache/1/small_image/1000x/9df78eab33525d08d6e5fb8d27136e95/k/h/khoai-t_y-chi_n-_m_.jpg',N'FRIES SIZE S')
---


insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Khoai tây chiên size m','DM007','SH001','5','27000','50','https://burgerking.vn/media/catalog/product/cache/1/small_image/1000x/9df78eab33525d08d6e5fb8d27136e95/k/h/khoai-t_y-chi_n-_m__1.jpg',N'FRIES SIZE M')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Khoai tây chiên size l','DM007','SH001','5','37000','50','https://burgerking.vn/media/catalog/product/cache/1/small_image/1000x/9df78eab33525d08d6e5fb8d27136e95/k/h/khoai-t_y-chi_n-_l_.jpg',N'FRIES SIZE L')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Cánh Gà BBQ Kiểu Mỹ (4 miếng)','DM005','SH002','5','89000','50','https://img.dominos.vn/MENU-PC_Ca%CC%81nh-Ga%CC%80-BBQ-Kie%CC%82%CC%89u-My%CC%83-.jpg',N'Cánh gà nướng ăn kèm với xốt BBQ')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Gà Không Xương BBQ','DM005','SH001','5','79000','50','https://img.dominos.vn/MENU-MB_GA%CC%80-KHO%CC%82NG-XU%CC%9BO%CC%9BNG-BBQ.jpg',N'Gà Không Xương tẩm bột ăn cùng xốt BBQ ngon tuyệt.')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Gà Tẩm Bột Phô Mai','DM005','SH001','5','79000','50','https://img.dominos.vn/MENU-MB_Ga%CC%80-Ta%CC%82%CC%89m-Bo%CC%A3%CC%82t-Pho%CC%82-Mai.jpg',N'Gà tẩm bột với phô mai thơm béo, phủ thêm lớp thịt heo xông khói ăn cùng với xốt BBQ.')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Cánh Gà BBQ Kiểu Mỹ (6 miếng)','DM005','SH001','5','109000','50','https://img.dominos.vn/MENU-PC_Ca%CC%81nh-Ga%CC%80-BBQ-Kie%CC%82%CC%89u-My%CC%83-.jpg',N'Cánh gà nướng ăn kèm với xốt BBQ')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Chai Coca 1.5L','DM004','SH001','5','39000','50','https://img.dominos.vn/coke-1.5.jpg',N'CoCaCoLa')




-----
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Chai Fanta 1.5L','DM004','SH001','5','39000','50','https://img.dominos.vn/fanta-1.5.jpg',N'Nước cam')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Chai Fanta 1.5L','DM004','SH001','5','39000','50','https://img.dominos.vn/fanta-1.5.jpg',N'Nước cam')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Trà đào hạt chia 350ml','DM004','SH001','5','25000','50','https://img.dominos.vn/dao-hat-chia.jpg',N'Trà đào hạt chia 350ml')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Lon coca zero 330ml','DM004','SH001','5','20000','50','https://img.dominos.vn/coke-zero.jpg',N'Lon coca zero 330ml')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Trà chanh sả 350ml','DM004','SH001','5','25000','50','https://img.dominos.vn/chanh-sa.jpg',N'Trà chanh sả 350ml')
------



insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Lon coca plus 330ml','DM004','SH001','5','25000','50','https://img.dominos.vn/coke-light.jpg',N'Lon coca plus 330ml')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Nước suối Dasani 500ml','DM004','SH001','5','20000','50','https://img.dominos.vn/daisani.jpg',N'Nước suối Dasani 500ml')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Chai coca 390ml','DM004','SH002','5','20000','50','https://img.dominos.vn/coke-390.jpg',N'Chai coca 390ml')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Chai Fanta 390ml','DM004','SH002','5','20000','50','https://img.dominos.vn/fanta-390.jpg',N'Chai Fanta 390ml')
insert into SanPham(TenSP,IDDanhMuc, IDShop, DanhGia, Gia, soLuong, ImgSP, moTaSP) values (N'Chai Sprite 390ml','DM004','SH002','5','20000','50','https://img.dominos.vn/Sprite-390.jpg',N'Chai Sprite 390ml')