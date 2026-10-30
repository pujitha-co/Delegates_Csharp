using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.AnonymousDelegate
{
    delegate void PatientDelegate(string name, int age);
    delegate void BillDelegate(double amount);
    delegate void AppointmentDelegate(string patient, string doctor);
    delegate void EmergencyDelegate(int temperature);
    delegate void MedicineDelegate(string medicine, int quantity);
    delegate void RoomDelegate(int days, double charge);
    class HospitalManagement
    {
        
            static void Main()
            {
                PatientDelegate patient = delegate (string name, int age)
                {
                    Console.WriteLine("patient name " + name);
                    Console.WriteLine("patient age" + age);

                };
                patient("pujitha", 23);

                BillDelegate bill = delegate (double amount)
                {
                    double total = amount + (amount * 5 / 100);
                    Console.WriteLine(amount);
                    Console.WriteLine(total);
                };
                bill(2000);
                bill(6000);

                AppointmentDelegate appointment = delegate (string patient, string doctor)
                {
                    Console.WriteLine(patient + doctor);
                };

                appointment("pujiii", "skanda");

                EmergencyDelegate emergency = delegate (int temperature)
                {

                    if (temperature >= 39)
                    {
                        Console.WriteLine("high tempp");
                    }
                    else if (temperature >= 35)
                    {
                        Console.WriteLine("medium tempp");
                    }
                    else
                    {
                        Console.WriteLine("normal tempp");
                    }
                };

                emergency(34);

                MedicineDelegate medicine = delegate (string name, int quantity)
                {
                    Console.WriteLine("quantity" + name);
                    Console.WriteLine("quantity" + quantity);


                };

                medicine("paracetamol", 5);
                medicine("citrizen", 3);


                RoomDelegate room = delegate (int days, double charge)
                {
                    double total = days * charge;
                    Console.WriteLine("stayingdays" + days);
                    Console.WriteLine("chargefor staying" + charge);


                };

                room(5, 2000);
                room(6, 8000);
            }
        }

    }




