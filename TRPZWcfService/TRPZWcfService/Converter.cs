using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBLib;
using DBLib.DBModel;
namespace TRPZWcfService
{

    static class Converter
    {
        static public ModelsForWpf.Car ToCar(Car car, ModelsForWpf.User owner = null)
        {
            var ret = new ModelsForWpf.Car();
            ret.Id = car.Id;
            ret.Info = car.Info;
            ret.RegNum = car.RegNum;
            ret.Owner = owner;
            ret.UserTalons = new List<ModelsForWpf.Talon>();
            using (var rep = new TalonRep())
            {
                foreach (var t in rep.GetItems())
                    if (t.Car_Id == ret.Id)
                    {
                        var talon = ToTalon(t);
                        talon.Car = ret;
                        ret.UserTalons.Add(talon);
                    }
            }
            return ret;
        }
        static public ModelsForWpf.User ToUser(User user)
        {
            var ret = new ModelsForWpf.User();
            ret.Id = user.Id;
            ret.IsAdmin = user.IsAdmin;
            ret.PhoneNum = user.PhoneNum;
            ret.Password = user.Password;
            ret.Login = user.Login;
            ret.FullName = user.FullName;
            ret.Cars = new List<ModelsForWpf.Car>();
            using (var userCarRep = new UserCarRep())
            using (var carRep = new CarRep())
            {
                foreach (var uc in userCarRep.GetItems())
                    if (uc.Owner_Id == ret.Id)
                        ret.Cars.Add(ToCar(carRep.GetItem(uc.Car_Id), ret));
            }
            return ret;
        }

        static public ModelsForWpf.Talon ToTalon(Talon talon)
        {

            var ret = new ModelsForWpf.Talon(talon.Id, talon.One, talon.Two, null, null);
            using (var rep = new CarRep())
                ret.Car = ToCar(rep.GetItem(talon?.Car_Id ?? -1));
            using (var rep = new SlotRep())
                ret.Slot = ToSlot(rep.GetItem(talon?.Slot_Id ?? -1));

            return ret;
        }

        static public ModelsForWpf.Slot ToSlot(Slot slot, ModelsForWpf.Parking p = null)
        {
            var ret = new ModelsForWpf.Slot(slot.Id, new List<ModelsForWpf.Talon>(), slot.XCord, slot.YCord, null);
            using (var talonRep = new TalonRep())
            {
                foreach (var t in talonRep.GetItems())
                    if (t.Slot_Id == ret.Id)
                        ret.Talons.Add(ToTalon(t));
            }

            ret.Parking = p;
            return ret;
        }

        static public ModelsForWpf.Parking ToParking(Parking parking)
        {
            var ret = new ModelsForWpf.Parking(parking.Id, parking.Name, parking.Adress, new List<ModelsForWpf.Slot>());
            using (var slotRep = new SlotRep())
            {
                foreach (var s in slotRep.GetItems())
                    if (s.Parking_Id == ret.Id)
                        ret.Slots.Add(ToSlot(s, ret));
            }
            return ret;
        }
    }
}
