using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        private readonly AppContext _appContext = new AppContext();
    //   List<Buses> buses;
 
    // public RepositorioBuses()
    //     {
    //         buses= new List<Buses>()
    //         {
    //             new Buses{id=1,marca="Audi",modelo= 2020,kilometraje= 100000,numero_asientos= 4,placa= "POP678"},
    //             new Buses{id=2,marca="Toyota",modelo= 2021,kilometraje= 90000,numero_asientos= 16,placa= "OIU859"},
    //             new Buses{id=3,marca="Mazda",modelo= 2000,kilometraje= 150000,numero_asientos= 24,placa= "YUH859"}
 
    //         };
    //     }
 
        public IEnumerable<Buses> GetAll()
        {
           // return buses;
            return _appContext.Buses;
        }
 
        public Buses GetBusWithId(int id){
            //return buses.SingleOrDefault(b => b.id == id);
            return _appContext.Buses.Find(id);
        }

        public Buses Create(Buses newBus)
        {
        //    if(buses.Count > 0){
        //    newBus.id=buses.Max(r => r.id) +1; 
        //     }else{
        //        newBus.id = 1; 
        //     }
        //    buses.Add(newBus);
        //    return newBus;
        var addBus = _appContext.Buses.Add(newBus);
            _appContext.SaveChanges();
            return addBus.Entity;
        }


       public Buses Update(Buses newBus){
            //var bus= buses.SingleOrDefault(b => b.id == newBus.id);
            var bus = _appContext.Buses.Find(newBus.id);
            if(bus != null){
                bus.marca = newBus.marca;
                bus.modelo = newBus.modelo;
                bus.kilometraje = newBus.kilometraje;
                bus.numero_asientos = newBus.numero_asientos;
                bus.placa = newBus.placa;
                //GUARDA EN LA BD
                _appContext.SaveChanges();
            }
        return bus;
        }

        //public Buses Delete(int id)
        public void Delete(int id)
        {
        // var bus= buses.SingleOrDefault(b => b.id == id);
        // buses.Remove(bus);
        // return bus;
        var bus = _appContext.Buses.Find(id);
        if (bus == null)
            return;
        _appContext.Buses.Remove(bus);
        _appContext.SaveChanges();    
        }


    }
}
