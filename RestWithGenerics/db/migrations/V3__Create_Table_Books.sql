CREATE TABLE IF NOT EXISTS `books` (
  `id` bigint(20) NOT NULL,
  `author` longtext,
  `launchDate` datetime(6) NOT NULL,
  `price` decimal(65, 2) NOT NULL,
  `title` longtext,
  PRIMARY KEY (`id`)
)