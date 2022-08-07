
const d = document,
$pinta1 = d.querySelector("#pinta-1"),  
$pinta2 = d.querySelector("#pinta-2"),   
$pinta3 = d.querySelector("#pinta-3"),
$tr = d.createElement("tr"),
$th = d.createElement("th"),
$td = d.createElement("td"),
$td1 = d.createElement("td"),
$td2 = d.createElement("td"),
$fragment = d.createDocumentFragment();

var $index, $table = d.getElementById("tabla");
   
   

const cellSelection = () =>{
    for (let i = 0; i < $table.rows.length; i++) {
        $table.rows[i].onclick = function() {    
            if (this.rowIndex > 0 || $index == "undefined" ){    
            if(typeof $index !== "undefined"){
                $table.rows[$index].classList.toggle("row-selected");
            }
    
           $index = this.rowIndex; // obtengo el numero de la fila seleccionada
           
           
           this.classList.toggle("row-selected");
           let fila = $table.rows[$index].cells;
            $pinta1.textContent= "Descripcion: " + fila[1].innerHTML;
            $pinta2.textContent=  "Proveedor: " + fila[3].innerHTML;
            $pinta3.textContent=  "Precio: " + fila[2].innerHTML;
           }
     
        }
       
    }  
}


    
 const getAll = async () => {
    try {
      let response = await fetch("./data.json"),
      json = await response.json();
      if (!response.ok) throw { status: response.status, statusText: response.statusText };      
      json.forEach((el) => {
        $th.textContent = el.id;
        $tr.appendChild($th);
        $td.textContent = el.descripcion;
        $tr.appendChild($td);
        $td1.textContent = el.precio;
        $tr.appendChild($td1);
        $td2.textContent = el.proveedor;
        $tr.appendChild($td2);        
        let $clone = d.importNode($tr, true);
        $fragment.appendChild($clone);
      });

      $table.querySelector("tbody").appendChild($fragment);
    } catch (err) {
      let message = err.statusText || "Ocurrió un error";
      $table.insertAdjacentHTML(
        "afterend",
        `<p><b>Error ${err.status}: ${message}</b></p>`
      );
    }
  };
 


  d.addEventListener("DOMContentLoaded", (e) =>{
    getAll();
    cellSelection();

  });

 