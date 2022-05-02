/*
Navicat MySQL Data Transfer

Source Server         : envera
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : projekt

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2022-04-06 17:22:58
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
  `Artikal_ID` int(100) NOT NULL auto_increment,
  `Naziv_artikla` varchar(20) NOT NULL,
  `Vrsta_artikla` varchar(20) NOT NULL,
  `Cijena` double(100,2) NOT NULL,
  PRIMARY KEY  (`Artikal_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of artikal
-- ----------------------------
INSERT INTO `artikal` VALUES ('1', 'Doritos', 'Grickalice', '2.50');
INSERT INTO `artikal` VALUES ('2', 'Moja kravica', 'Mliječni proizvod ', '1.00');
INSERT INTO `artikal` VALUES ('3', 'Deon', 'Deterdžent', '10.00');
INSERT INTO `artikal` VALUES ('4', 'Senzacija', 'Sok', '1.50');
INSERT INTO `artikal` VALUES ('5', 'Bueno', 'Slatkiši', '1.50');
INSERT INTO `artikal` VALUES ('6', 'Jubilarna', 'Kafa mljevena', '7.95');
INSERT INTO `artikal` VALUES ('7', 'Pileći batak', 'Meso', '10.50');
INSERT INTO `artikal` VALUES ('8', 'Glatko', 'Brašno', '34.55');
INSERT INTO `artikal` VALUES ('9', 'Wudy', 'Hrenovke', '1.55');
INSERT INTO `artikal` VALUES ('10', 'Alpinese', 'Maslac za mazanje', '3.95');
INSERT INTO `artikal` VALUES ('11', 'Argeta', 'Kokošija pašteta', '1.45');
INSERT INTO `artikal` VALUES ('12', 'Barilla', 'Špagete', '2.85');
INSERT INTO `artikal` VALUES ('13', 'Milka', 'Krem namaz', '4.45');
INSERT INTO `artikal` VALUES ('14', 'Cedevita', 'Sok', '8.95');
INSERT INTO `artikal` VALUES ('15', 'Nivea', 'Krema', '1.65');
INSERT INTO `artikal` VALUES ('16', 'Violeta', 'Toaletni papir', '6.50');
INSERT INTO `artikal` VALUES ('17', 'Klass', 'Hljeb', '1.30');
INSERT INTO `artikal` VALUES ('18', 'Becutan', 'Šampon', '4.50');
INSERT INTO `artikal` VALUES ('19', 'Nutella', 'Krem namaz', '7.50');
INSERT INTO `artikal` VALUES ('20', 'Plazma', 'Slatkiš', '1.70');

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
  `Kupac_ID` int(100) NOT NULL auto_increment,
  `Ime` varchar(15) NOT NULL,
  `Prezime` varchar(20) NOT NULL,
  `Grad` varchar(10) default NULL,
  `Adresa` varchar(25) default NULL,
  `Telefon` varchar(20) default NULL,
  `User` varchar(15) NOT NULL,
  `Pass` varchar(15) NOT NULL,
  PRIMARY KEY  (`Kupac_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of kupac
-- ----------------------------
INSERT INTO `kupac` VALUES ('1', 'Envera', 'Mulahasanović', 'Sarajevo', 'Kapetana Hajre 13', '062-113-255', 'envera.m', '1.envera.m');
INSERT INTO `kupac` VALUES ('2', 'Azra', 'Pamuk', 'Bihać', 'Huseina Đoze 15', '060-183-2361', 'azra.p', '2azra.p');
INSERT INTO `kupac` VALUES ('3', 'Mina', 'Trgo', 'Mostar', 'Ahmeda Ljubunčića 2', '061-562-478', 'mina.t', '3mina.t');
INSERT INTO `kupac` VALUES ('4', 'Erduana', 'Bećar', 'Sarajevo', 'Albanska 31', '062-948-344', 'erduana.b', '4erduana.b');
INSERT INTO `kupac` VALUES ('5', 'Elvedin', 'Mujezinović', 'Foča', 'Gatačka 67', '062-347-903', 'elvedin.m', '5elvedin.m');
INSERT INTO `kupac` VALUES ('6', 'Irhad', 'Selimović', 'Konjic', 'Kodžina 47', '061-884-233', 'irhad.s', '6irhad.s');
INSERT INTO `kupac` VALUES ('7', 'Mirza', 'Hodžić', 'Banja Luka', 'Trg Solidarnosti 1', '060-548-9921', 'mirza.h', '7mirza.h');
INSERT INTO `kupac` VALUES ('8', 'Maja', 'Petrović', 'Tuzla', 'Adema Buće 22', '062-553-683', 'maja.p', '8maja.p');
INSERT INTO `kupac` VALUES ('9', 'Ahmed', 'Halilović', 'Mostar', 'Braće Kovačević 53', '061-224-765', 'ahmed.h', '9ahmed.h');
INSERT INTO `kupac` VALUES ('10', 'Zijad', 'Avdić', 'Zenica', 'Safeta Isovića 18', '062-261-554', 'zijad.a', '10zijad.a');

-- ----------------------------
-- Table structure for `narudžbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudžbenica`;
CREATE TABLE `narudžbenica` (
  `Narudžbenica_ID` int(100) NOT NULL auto_increment,
  `Kupac_ID` int(100) NOT NULL,
  `Datum_narudžbe` date default NULL,
  PRIMARY KEY  (`Narudžbenica_ID`),
  KEY `Kupac` (`Kupac_ID`),
  CONSTRAINT `Kupac` FOREIGN KEY (`Kupac_ID`) REFERENCES `kupac` (`kupac_ID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of narudžbenica
-- ----------------------------
INSERT INTO `narudžbenica` VALUES ('1', '1', '2022-03-24');
INSERT INTO `narudžbenica` VALUES ('2', '4', '2022-04-01');
INSERT INTO `narudžbenica` VALUES ('3', '10', '2022-03-14');
INSERT INTO `narudžbenica` VALUES ('4', '7', '2021-12-18');
INSERT INTO `narudžbenica` VALUES ('5', '2', '2022-02-09');
INSERT INTO `narudžbenica` VALUES ('6', '5', '2021-11-17');
INSERT INTO `narudžbenica` VALUES ('7', '9', '2022-02-14');
INSERT INTO `narudžbenica` VALUES ('8', '3', '2022-04-06');
INSERT INTO `narudžbenica` VALUES ('9', '6', '2022-03-28');
INSERT INTO `narudžbenica` VALUES ('10', '8', '2022-03-09');
INSERT INTO `narudžbenica` VALUES ('11', '1', '2022-04-02');
INSERT INTO `narudžbenica` VALUES ('12', '10', '2022-04-02');

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
  `Skladište_ID` int(100) NOT NULL auto_increment,
  `Artikal_ID` int(100) NOT NULL,
  `Količina_stanje` int(255) NOT NULL,
  PRIMARY KEY  (`Skladište_ID`),
  KEY `Artikall` (`Artikal_ID`),
  CONSTRAINT `Artikall` FOREIGN KEY (`Artikal_ID`) REFERENCES `artikal` (`Artikal_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of skladiste
-- ----------------------------
INSERT INTO `skladiste` VALUES ('1', '1', '100');
INSERT INTO `skladiste` VALUES ('2', '2', '53');
INSERT INTO `skladiste` VALUES ('3', '3', '77');
INSERT INTO `skladiste` VALUES ('4', '4', '125');
INSERT INTO `skladiste` VALUES ('5', '5', '200');
INSERT INTO `skladiste` VALUES ('6', '6', '32');
INSERT INTO `skladiste` VALUES ('7', '7', '19');
INSERT INTO `skladiste` VALUES ('8', '8', '15');
INSERT INTO `skladiste` VALUES ('9', '9', '68');
INSERT INTO `skladiste` VALUES ('10', '10', '94');
INSERT INTO `skladiste` VALUES ('11', '11', '247');
INSERT INTO `skladiste` VALUES ('12', '12', '70');
INSERT INTO `skladiste` VALUES ('13', '13', '29');
INSERT INTO `skladiste` VALUES ('14', '14', '134');
INSERT INTO `skladiste` VALUES ('15', '15', '115');
INSERT INTO `skladiste` VALUES ('16', '16', '200');
INSERT INTO `skladiste` VALUES ('17', '17', '88');
INSERT INTO `skladiste` VALUES ('18', '18', '9');
INSERT INTO `skladiste` VALUES ('19', '19', '46');
INSERT INTO `skladiste` VALUES ('20', '20', '104');

-- ----------------------------
-- Table structure for `stavka_narudžbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudžbenice`;
CREATE TABLE `stavka_narudžbenice` (
  `Stavka_ID` int(100) NOT NULL auto_increment,
  `Narudžbenica_ID` int(100) NOT NULL,
  `Artikal_ID` int(100) NOT NULL,
  `Količina` int(255) default NULL,
  PRIMARY KEY  (`Stavka_ID`),
  KEY `Narudžbenica` (`Narudžbenica_ID`),
  KEY `Artikal` (`Artikal_ID`),
  CONSTRAINT `Artikal` FOREIGN KEY (`Artikal_ID`) REFERENCES `artikal` (`Artikal_ID`) ON UPDATE CASCADE,
  CONSTRAINT `Narudžbenica` FOREIGN KEY (`Narudžbenica_ID`) REFERENCES `narudžbenica` (`Narudžbenica_ID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of stavka_narudžbenice
-- ----------------------------
INSERT INTO `stavka_narudžbenice` VALUES ('1', '1', '4', '2');
INSERT INTO `stavka_narudžbenice` VALUES ('2', '2', '10', '1');
INSERT INTO `stavka_narudžbenice` VALUES ('3', '3', '17', '5');
INSERT INTO `stavka_narudžbenice` VALUES ('4', '4', '1', '4');
INSERT INTO `stavka_narudžbenice` VALUES ('5', '5', '5', '15');
INSERT INTO `stavka_narudžbenice` VALUES ('6', '6', '8', '1');
INSERT INTO `stavka_narudžbenice` VALUES ('7', '7', '2', '3');
INSERT INTO `stavka_narudžbenice` VALUES ('8', '8', '15', '1');
INSERT INTO `stavka_narudžbenice` VALUES ('9', '9', '6', '5');
INSERT INTO `stavka_narudžbenice` VALUES ('10', '10', '14', '1');
INSERT INTO `stavka_narudžbenice` VALUES ('11', '11', '7', '6');
INSERT INTO `stavka_narudžbenice` VALUES ('12', '12', '13', '2');
INSERT INTO `stavka_narudžbenice` VALUES ('13', '4', '9', '4');
INSERT INTO `stavka_narudžbenice` VALUES ('14', '9', '3', '2');
INSERT INTO `stavka_narudžbenice` VALUES ('15', '4', '20', '7');
