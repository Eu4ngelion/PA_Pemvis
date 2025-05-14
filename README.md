# Proyek Akhir Pemrogram Visual
## Anggota
- Ahmad Zuhair Nur Aiman
- Demosa Guardy Nugroho
- Injil Karepowan
- Zulfikar Heriansyah

## Database = dbHaven
NB: Import databasenya dulu (/resource/dbhaven.sql)
Admin= (Username = admin, Pass = admin123)

### tbUser
- id : Integer (PK, Auto_Increment)
- username : Varchar(20)
- password : varchar(20)
- Role : Enum ('member', 'admin')

### tbbBuku
- id : Integer (PK, Auto_Increment)
- Judul : Varchar(50)
- Penulis : Varchar(50)
- Tahun_Terbit : Varchar(4)
- Jenis : Varchar(20)
- Genre : Varchar(20)
- Harga : Double
- Stok : Integer
- Deskripsi : (Text, NULLable)
- Cover : longblob

### tbkeranjang
- id : Integer (PK, Auto_Increment)
- id_user : Integer (FK)
- id_buku : Integer (FK)
- jumlah : Integer
  


