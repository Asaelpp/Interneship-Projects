using ConstNavesTeste.Data;
using ConstNavesTeste.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConstNavesTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NaveController : ControllerBase
    {
        //aqui eu crio a lista para gerar ela no POST/GET/DELETE etc

        private NaveContext _context;

        public NaveController(NaveContext context)
        {
            _context = context;
        }
        
        //private static List<SpaceShip> naves = new List<SpaceShip>();
        //private static int Id = 1;
        
        
        [HttpPost]
       //aqui eu monto um construtor para postar a lista 
        public IActionResult AddNave([FromBody]SpaceShip nave)
        {
            _context.Naves.Add(nave);
            _context.SaveChanges();
            
            //nave.IdNave = Id++;
            //naves.Add(nave);
            
            System.Console.WriteLine(nave.Nome);
            
            //método criado para estabelecer aonde o próprio foi criado
            return CreatedAtAction(nameof(NaveId), new {Id = nave.Id}, nave);
        }

        
        [HttpGet]
        //construtor para retornar a lista de Naves 

        public IEnumerable<SpaceShip> RecuperarNaves()
        {
            return _context.Naves;
        }
        
        //public IEnumerable<SpaceShip> RecuperarNaves()
        //{
        //    return naves;
        //}

        
        //construtor para retornar a lista por ID ... o ctor foi trocado de "public SpaceShip NaveId(int id)" 
        // para "public IActionResult NaveId(int id)" por que o valor "OK" e "NotFound" são resultado de objetos ( ObjectResult) e
        // sendo assim o IAction é necessário para retornar o resultado
        [HttpGet("{id}")]
        public IActionResult NaveId(int id)
        {

            SpaceShip nave =  _context.Naves.FirstOrDefault(nave => nave.Id == id);
            if (nave != null)
            {
                return Ok(nave);
            }
            return NotFound();

            //foreach (SpaceShip nave in naves )
            //{
            //    if (nave.IdNave == id)
            //    {
            //        return nave;
            //    }
            //}
            //return null;


        }

        [HttpPut("{id}")]
        public IActionResult AtualizaNave(int id, [FromBody] SpaceShip naveNova)
        {
            SpaceShip nave = _context.Naves.FirstOrDefault(nave => nave.Id == id);
            if (nave == null)
            {
                return NotFound();
            }
            nave.Nome = naveNova.Nome;
            nave.Modelo = naveNova.Modelo;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaNave(int id)
        {
            SpaceShip nave = _context.Naves.FirstOrDefault(nave => nave.Id == id);
            if (nave == null)
            {
                return NotFound();
            }
            _context.Remove(nave);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
