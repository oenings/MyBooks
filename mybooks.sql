drop database mybooks;

create database mybooks;
use mybooks;

create table ebooks (
	eid     int primary key auto_increment,
	titel   varchar(50),
	autor   varchar(30),
	form    enum("epub", "pdf", "mobi")
);

insert into ebooks values (null, "SQL Einführung", "Ralf Adams", "epub");
insert into ebooks values (null, "SQL Einführung", "Ralf Adams", "pdf");
insert into ebooks values (null, "SQL Einführung", "Ralf Adams", "mobi");
insert into ebooks values (null, "Visual c# 2012", "Walter Doberenz", "pdf");
insert into ebooks values (null, "Datenbanksysteme", "Lothar Meyer", "epub");
