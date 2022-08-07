const d = document,
$tr = d.createElement("tr"),
$th = d.createElement("th"),
$td = d.createElement("td"),
$td1 = d.createElement("td"),
$td2 = d.createElement("td"),
$fragment = d.createDocumentFragment();
    
export const getAll = async () => {
    try {
      let response = await fetch("../data.json"),
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
 