using Business.Concrete;
using Entities.Concrete;



Person person1 = new Person();
person1.FirstName = "Melih";
person1.LastName = " Gacav";
person1.DateOfBirthYear = 2000;
person1.NationalIdentity = 1234567891;

PttManager pttmanager = new PttManager(new PersonManager());
pttmanager.GiveMask(person1);
Console.ReadLine();
