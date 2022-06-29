create database tokohp1;

create table barang
(id_barang varchar(4) primary key,
nama_barang varchar(15),
harga varchar (9),
id_pemasok varchar(4))

--1 Procedure insert data barang
Create procedure insertbarang
@id_barang varchar (4),
@nama_barang varchar (15),
@harga varchar (9),
@id_pemasok varchar (4)
As
insert into barang(id_barang,nama_barang,harga,id_pemasok)
values (@id_barang,@nama_barang,@harga,@id_pemasok)


--Procedure menghapus data barang
create procedure deletebarang
@id_barang varchar
as
delete from barang where id_barang = @id_barang 


--Procedure update data barang
Create procedure updatebarang
@id_barang varchar (4),
@nama_barang varchar (15),
@harga varchar (9),
@id_pemasok varchar (4)
as
update barang set id_barang = @id_barang, nama_barang = @nama_barang,
harga = @harga, id_pemasok = @id_pemasok where id_barang = @id_barang

--Procedure search data barang
 Create procedure searchbarang
@id_barang varchar (4)
AS
SELECT*FROM barang WHERE id_barang=@id_barang

create table keterangan_penjualan(
id_nota varchar(4) primary key, harga varchar(9), jumlah_barang varchar(6), id_barang varchar(4))

--1 Procedure insert data keterangan penjualan
Create procedure insertketjual
@id_nota varchar (4),
@harga varchar (6),
@jumlah_barang varchar (9),
@id_barang varchar (4)
AS
BEGIN

SET NOCOUNT ON;

insert into keterangan_penjualan(id_nota,harga,jumlah_barang,id_barang)
values (@id_nota,@harga,@jumlah_barang,@id_barang)
END
GO

--Procedure menghapus data keterangan penjualan
create procedure deleteketjual
@id_nota varchar(4)
as
delete from keterangan_penjualan where id_nota = @id_nota 


--Procedure update keterangan penjualan
Create procedure updateketjual
@id_nota varchar (4),
@harga varchar (6),
@jumlah_barang varchar (9),
@id_barang varchar (4)
as
update keterangan_penjualan set id_nota = @id_nota, harga = @harga,
jumlah_barang = @jumlah_barang, id_barang = @id_barang where id_nota = @id_nota



--Procedure tampil keterangan penjualan
create procedure tampilketjual
As
select*from keterangan_penjualan


--Procedure search keterangan penjualan
 Create procedure searchketjual
@id_nota varchar (4)
AS
SELECT*FROM keterangan_penjualan WHERE id_nota=@id_nota

create table keterangan_pembelian(
id_barang varchar(4) primary key, jumlah_barang varchar(6), harga varchar(9), id_nota varchar(4), id_pegawai varchar(4))

--1 Procedure insert data keterangan pembelian
Create procedure insertketbeli
@id_barang varchar (4),
@jumlah_barang varchar (6),
@harga varchar (9),
@id_nota varchar (4),
@id_pegawai varchar (4)
AS
BEGIN

SET NOCOUNT ON;

insert into keterangan_pembelian(id_barang,jumlah_barang,harga,id_nota,id_pegawai)
values (@id_barang,@jumlah_barang,@harga,@id_nota,@id_pegawai)
END
GO

--Procedure menghapus data keterangan pembelian
create procedure deleteketbeli
@id_barang varchar(4)
as
delete from keterangan_pembelian where id_barang = @id_barang 


--Procedure update keterangan pembelian
Create procedure updateketbeli
@id_barang varchar (4),
@jumlah_barang varchar (6),
@harga varchar (9),
@id_nota varchar (4),
@id_pegawai varchar (4)
as
update keterangan_pembelian set id_barang = @id_barang, jumlah_barang = @jumlah_barang,
harga = @harga, id_nota = @id_nota, id_pegawai = @id_pegawai where id_barang = @id_barang



--Procedure tampil keterangan pembelian
create procedure tampilketbeli 
As
select*from keterangan_pembelian

--Procedure search keterangan pembelian
 Create procedure searchketbeli
@id_barang varchar (4)
AS
SELECT*FROM keterangan_pembelian WHERE id_barang=@id_barang