using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace AutoSalonMac.App.Extensions
{
    public static class ServisnaStavkaExtension
    {
        public static ServisnaStavkaTableDTO ToServisnaStavkaTableDTO(this ServisnaStavka stavka)
        {
            return new ServisnaStavkaTableDTO
            {
                ID = stavka.ID,
                Opis = stavka.Opis,
                Datum = stavka.Datum,

                //ovde treba da se doda toDTO za vozilo?
                Vozilo = stavka.Vozilo
            };
        }

        public static ServisnaStavka ServisnaStavkaTableToEntity(this ServisnaStavkaTableDTO stavkaDto)
        {
            return new ServisnaStavka
            {
                ID = stavkaDto.ID,
                Opis = stavkaDto.Opis,
                Datum = stavkaDto.Datum,

                //ovde treba da se doda toEntity za vozilo?
                Vozilo = stavkaDto.Vozilo
            };
        }
    }
}