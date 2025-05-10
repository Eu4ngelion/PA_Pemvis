# Proyek Akhir Pemrogram Visual
## Database = dbHaven
### NB: Import databasenya dulu (/resource/dbhaven.sql)

### tbUser
- id : Integer (PK, Auto_Increment)
- username : Varchar(20)
- password : varchar(20)
- Role : Enum ('member', 'admin')

### tbbBuku
- id : Integer (PK, Auto_Increment)
- Nama : Varchar(50)
- Penulis : Varchar(50)
- Jenis : Varchar(20)
- Genre : Varchar(20)
- Harga : Double
- Stok : Integer
- Deskripsi : (Text, NULLable)

### tbkeranjang
- id : Integer (PK, Auto_Increment)
- id_user : Integer (FK)
- id_buku : Integer (FK)
- nama_buk: Varchar (20)_
- jumlah : Integer
- total_harga : Double
  
## Anggota
- Ahmad Zuhair Nur Aiman
- Demosa Guardy Nugroho
- Injil Karepowan
- Zulfikar Heriansyah

