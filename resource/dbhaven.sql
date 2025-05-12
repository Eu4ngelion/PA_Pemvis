-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: May 12, 2025 at 01:55 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbhaven`
--
CREATE DATABASE IF NOT EXISTS `dbhaven` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `dbhaven`;

-- --------------------------------------------------------

--
-- Table structure for table `tbbuku`
--

CREATE TABLE `tbbuku` (
  `Id` int(11) NOT NULL,
  `Judul` varchar(50) NOT NULL,
  `Penulis` varchar(50) NOT NULL,
  `Tahun_Terbit` varchar(4) NOT NULL,
  `Jenis` varchar(20) NOT NULL,
  `Genre` varchar(255) NOT NULL,
  `Harga` double NOT NULL,
  `Stok` int(11) NOT NULL,
  `Deskripsi` text DEFAULT NULL,
  `Cover` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbkeranjang`
--

CREATE TABLE `tbkeranjang` (
  `id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `id_buku` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbuser`
--

CREATE TABLE `tbuser` (
  `id` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` enum('member','admin') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbuser`
--

INSERT INTO `tbuser` (`id`, `username`, `password`, `role`) VALUES
(1, 'admin', 'admin123', 'admin'),
(2, 'user1', 'user1', 'member'),
(3, 'user2', 'user2', 'member');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbbuku`
--
ALTER TABLE `tbbuku`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `buku_keranjang` (`id_buku`) USING BTREE;

--
-- Indexes for table `tbuser`
--
ALTER TABLE `tbuser`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `usn` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbbuku`
--
ALTER TABLE `tbbuku`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbuser`
--
ALTER TABLE `tbuser`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD CONSTRAINT `keranjang-buku` FOREIGN KEY (`id_buku`) REFERENCES `tbbuku` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `keranjang-user` FOREIGN KEY (`id_user`) REFERENCES `tbuser` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
