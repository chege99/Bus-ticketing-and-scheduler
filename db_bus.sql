-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 28, 2019 at 07:26 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_bus`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_bookings`
--

CREATE TABLE `tbl_bookings` (
  `entry_id` int(10) NOT NULL,
  `voyage_id` int(20) NOT NULL,
  `customer_id` int(20) NOT NULL,
  `mode_of_payment` varchar(50) NOT NULL,
  `amount_paid` double(10,2) DEFAULT NULL,
  `tickey_number` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_buses`
--

CREATE TABLE `tbl_buses` (
  `bus_id` int(10) NOT NULL,
  `bus_name` varchar(45) NOT NULL,
  `capacity` int(10) NOT NULL,
  `plate_number` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_buses`
--

INSERT INTO `tbl_buses` (`bus_id`, `bus_name`, `capacity`, `plate_number`) VALUES
(7, 'Alvin', 20, 'KBC120');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer`
--

CREATE TABLE `tbl_customer` (
  `customer_id` int(10) NOT NULL,
  `person_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_customer`
--

INSERT INTO `tbl_customer` (`customer_id`, `person_id`) VALUES
(5, 14),
(6, 17);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_drivers`
--

CREATE TABLE `tbl_drivers` (
  `driver_id` int(10) NOT NULL,
  `person_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_drivers`
--

INSERT INTO `tbl_drivers` (`driver_id`, `person_id`) VALUES
(5, 15);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_people`
--

CREATE TABLE `tbl_people` (
  `person_id` int(10) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `email` varchar(20) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `national_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_people`
--

INSERT INTO `tbl_people` (`person_id`, `fname`, `lname`, `email`, `phone`, `national_id`) VALUES
(13, 'Steve', 'Gitau', 'steve@gmail.com', '0714587808', 35185595),
(14, 'Joe', 'Arif', 'joe@mail.com', '0708049796', 35185595),
(15, 'David', 'Mburu', 'david@gmail.com', '0712697968', 34534561),
(16, 'steve', 'gitau', 'steve@gmail.com', '0708060798', 12012098),
(17, 'samuel', 'thio', 'sam@gmail.com', '0789453434', 12325678);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_routes`
--

CREATE TABLE `tbl_routes` (
  `route_id` int(10) NOT NULL,
  `routename` varchar(100) NOT NULL,
  `pickuppoint` varchar(50) NOT NULL,
  `destination` varchar(50) NOT NULL,
  `charge` double(10,2) DEFAULT NULL,
  `description` varchar(250) NOT NULL,
  `estimated_time` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_routes`
--

INSERT INTO `tbl_routes` (`route_id`, `routename`, `pickuppoint`, `destination`, `charge`, `description`, `estimated_time`) VALUES
(3, 'Route X', 'Ngara', 'Voi', 1000.00, 'From Ngara to voi through the bushes', 10);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_schedules`
--

CREATE TABLE `tbl_schedules` (
  `entry_id` int(50) NOT NULL,
  `bus_name` varchar(50) NOT NULL,
  `driver_name` varchar(50) NOT NULL,
  `route_name` varchar(50) NOT NULL,
  `time_depart` time NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_schedules`
--

INSERT INTO `tbl_schedules` (`entry_id`, `bus_name`, `driver_name`, `route_name`, `time_depart`, `date`) VALUES
(13, 'Alvin', 'David', 'Route X', '17:02:00', '2019-08-19'),
(14, 'Alvin', 'David', 'Route X', '06:30:00', '2019-08-19');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tickets`
--

CREATE TABLE `tbl_tickets` (
  `entry_id` int(11) NOT NULL,
  `voyage_id` int(20) NOT NULL,
  `customer_id` int(20) NOT NULL,
  `amount_paid` double(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_tickets`
--

INSERT INTO `tbl_tickets` (`entry_id`, `voyage_id`, `customer_id`, `amount_paid`) VALUES
(13, 13, 6, 1000.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_users`
--

CREATE TABLE `tbl_users` (
  `user_id` int(10) NOT NULL,
  `user_type` varchar(20) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `person_id` int(10) NOT NULL,
  `reset_token` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_users`
--

INSERT INTO `tbl_users` (`user_id`, `user_type`, `username`, `password`, `person_id`, `reset_token`) VALUES
(1, 'admin', 'admin', 'admin', 0, 0),
(6, 'Type', 'steve', '12345678', 16, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_voyages`
--

CREATE TABLE `tbl_voyages` (
  `voyage_id` int(10) NOT NULL,
  `bus_id` int(20) NOT NULL,
  `route_id` int(20) NOT NULL,
  `driver_id` int(20) NOT NULL,
  `departure_time` time NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_bookings`
--
ALTER TABLE `tbl_bookings`
  ADD PRIMARY KEY (`entry_id`);

--
-- Indexes for table `tbl_buses`
--
ALTER TABLE `tbl_buses`
  ADD PRIMARY KEY (`bus_id`);

--
-- Indexes for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `tbl_drivers`
--
ALTER TABLE `tbl_drivers`
  ADD PRIMARY KEY (`driver_id`);

--
-- Indexes for table `tbl_people`
--
ALTER TABLE `tbl_people`
  ADD PRIMARY KEY (`person_id`);

--
-- Indexes for table `tbl_routes`
--
ALTER TABLE `tbl_routes`
  ADD PRIMARY KEY (`route_id`);

--
-- Indexes for table `tbl_schedules`
--
ALTER TABLE `tbl_schedules`
  ADD PRIMARY KEY (`entry_id`);

--
-- Indexes for table `tbl_tickets`
--
ALTER TABLE `tbl_tickets`
  ADD PRIMARY KEY (`entry_id`);

--
-- Indexes for table `tbl_users`
--
ALTER TABLE `tbl_users`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `tbl_voyages`
--
ALTER TABLE `tbl_voyages`
  ADD PRIMARY KEY (`voyage_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_bookings`
--
ALTER TABLE `tbl_bookings`
  MODIFY `entry_id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_buses`
--
ALTER TABLE `tbl_buses`
  MODIFY `bus_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  MODIFY `customer_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_drivers`
--
ALTER TABLE `tbl_drivers`
  MODIFY `driver_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_people`
--
ALTER TABLE `tbl_people`
  MODIFY `person_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbl_routes`
--
ALTER TABLE `tbl_routes`
  MODIFY `route_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_schedules`
--
ALTER TABLE `tbl_schedules`
  MODIFY `entry_id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tbl_tickets`
--
ALTER TABLE `tbl_tickets`
  MODIFY `entry_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_users`
--
ALTER TABLE `tbl_users`
  MODIFY `user_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_voyages`
--
ALTER TABLE `tbl_voyages`
  MODIFY `voyage_id` int(10) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
