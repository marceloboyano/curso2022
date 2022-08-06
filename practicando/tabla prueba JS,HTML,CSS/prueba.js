

const d = document,
$fragment = d.createDocumentFragment(),
$pinta1 = d.querySelector("#pinta-1"),  
$pinta2 = d.querySelector("#pinta-2"),   
$pinta3 = d.querySelector("#pinta-3"),   
$pinta4 = d.querySelector("#pinta-4");  
var $index, $table = d.getElementById("tabla");
       

      
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
