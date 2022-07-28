const d = document,
      $id= d.querySelector("#fizzbuzzList"),
      $fizz= d.querySelector(".fizzbuzz-list"),
      $ul = d.createElement("ul"),
      $fragment = d.createDocumentFragment();

    function enviarValoresAlApi() 
    {
    console.log("llamando al api...");
    var inferior = document.getElementById("inferior").value;
    var superior = document.getElementById("superior").value;
    console.log("AGREGA VALIDACIONES Y CHEQUEA QUE INFERIOR Y SUPERIOR SEAN NUMEROS");
    console.log("Inferior: " + inferior);
    console.log("Superior: " + superior);
    execute(inferior, superior);
  
    }   
     
//Create - POST
async function Output(string)
 {
try {
    let options = {
      method: "POST",
      headers: {
        "Content-type": "application/json; charset=utf-8",
      },
      body: JSON.stringify({
        id: uuid.v1(),
        fizzBuzzValue: string,
      
      }),
    },
      res = await fetch("http://localhost:5199/api/fizzbuzz", options),
      json = await res.json();

    if (!res.ok)
      throw { status: res.status, statusText: res.statusText };

    location.reload();
  } catch (err) {
    let message = err.statusText || "Ocurrió un error";
  }
  console.log (string);
 }

 


async function execute(Inferior,Superior)
{

    if (validaciones(Inferior, Superior))
    {
        await Output("Los Datos ingresados son incorrectos." +
           "\n* No se puede ingresar numeros negativos" +
           " \n* El limite superior no puede ser menor que el limite inferior" +
           " \n* los limites no pueden ser mayores que 10mil");
        return;
    }
    
    for (var i = Inferior; i <= Superior; i++)
    {
        if (i % 3 != 0 || i % 5 != 0)
        {
            if (i % 5 == 0 || i % 3 == 0)
            {
                if (i % 5 != 0)
                {

                      await Output("FIZZ");

                }
                else
                {
                     await Output("BUZZ");
                }
            }
            else
            {
                 await Output("numero: " + i);
            }
        }
        else
        {
            await Output("FIZZBUZZ");

        }

    }


}



function validaciones(inferior, superior) 
{
  return  inferior < 0 
    || superior < 0 
    || superior < inferior 
    || superior > 10000 || inferior > 10000;
}
async function getAll() 
    {       
     
      try {
        let res = await fetch("http://localhost:5199/api/fizzbuzz"),
          json = await res.json();
      
        if (!res.ok) throw { status: res.status, statusText: res.statusText };
        
        console.log(json);
        json.forEach((el) => {            
            console.log(el);
            const $li = document.createElement("li");
            $li.textContent= el.fizzBuzzDTO;           
           $fragment.appendChild($li);                  
           console.log($li);       
        });                
          console.log ($fragment);
            $ul.appendChild($fragment);           
           d.querySelector(".fizzbuzz-list").insertAdjacentElement("afterbegin", $ul);         
 
       
      } catch (err) {
        let message = err.statusText || "Ocurrió un error";      
      }
    }

    