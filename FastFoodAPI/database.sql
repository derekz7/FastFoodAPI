use FastFoodApp
go

insert into DanhMuc(TenDanhMuc,ImgDM,moTa) values (N'Tất cả','https://imgur.com/mX0VUay.png',N'Tất cả')
delete DanhMuc

update DanhMuc set ImgDM = 'https://imgur.com/xAi8SJw.png' where IDDanhMuc = 'DM005'
select * from DanhMuc


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
exec addSanPham N'Burger Double Double', 'DM002', 'SH001',59000,20,'https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/1e747a0edfedb1f60dd6ec5ad21ff8df/b/u/burger-534x374px_ddouble-burger.png'
exec addSanPham N'Burger Tôm', 'DM002', 'SH001',49000,20,'https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/b/u/burger-534x374px_shrimp-burger.png'
exec addSanPham N'Burger Gà Thượng Hải', 'DM002', 'SH001',43000,20,'https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/b/u/burger-534x374px_chicken-burger.png'

select * from SanPham
select * from HinhAnh

update SanPham set DanhGia = 5 where IDDanhMuc = 'DM002'

alter table SanPham add moTaSP NVARCHAR(300)

Insert into HinhAnh(imgUrl,IDSP) values ('https://ngonaz.com/wp-content/uploads/2021/10/cach-lam-pizza-xuc-xich-1.jpg','SP004')
Insert into HinhAnh(imgUrl,IDSP) values ('http://www.monngon.tv/uploads/images/images/pizza-xuc-xich-1.jpg','SP004')
Insert into HinhAnh(imgUrl,IDSP) values ('https://www.monngon.tv/uploads/images/images/cach-lam-pizza-bo-xuc-xich-5.jpg','SP004')

update SanPham set moTaSP = N'Thành phần: Bột mỳ, phomai, nước, xúc xích (≥ 3 %), hành tây, ngô ngọt, ớt chuông, tương cà (< 5 %), bơ (< 5 %), dầu ăn, đường kính, men bánh (< 5 %), muối ăn.' where IDSP = 'SP004'