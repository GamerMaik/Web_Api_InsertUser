using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class SWLNPersona
    {
        #region Metodos Publicos
        public void Adicionar_Persona(EPersona eEpersona)
        {
            try
            {
                using (var context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>()))
                {
                    context.Persona.Add(eEpersona);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar cambios en la base de datos");
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public void Editar_Persona(EPersona eEpersona)
        {
            try
            {
                using (var context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>()))
                {
                    // Verificar si la entidad ya existe en la base de datos
                    var personaExistente = context.Persona.Find(eEpersona.Id);

                    if (personaExistente != null)
                    {
                        // Actualizar los campos de la entidad existente con los valores de eEpersona
                        context.Entry(personaExistente).CurrentValues.SetValues(eEpersona);

                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("La persona no existe en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar cambios en la base de datos");
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

		public void UwU(int i)
		{
			// AAAAAAAAAAAAAAAAAAAA
            // BBBBBBBBBBBBBBBB
            // CCCCCCCCCCCCCCCC
            // DDDDDDDDDDDDDDDD
            // EEEEEEEEEEEEEEEE123
            // FFFFFFFFF
            // GGGGGGGGG
		}
		#endregion
	}
}
