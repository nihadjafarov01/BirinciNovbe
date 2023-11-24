function getCharacters(link)
{
    return fetch(link)
        .then(res=>res.json())
}

async function toHtml()
{
    //let link = `https://api.disneyapi.dev/character?page=${page}&pageSize=${size}`;
    let link = `https://restcountries.com/v3.1/all`;
    let response = await getCharacters(link); 
    fillHTML(response)
}
function fillHTML(datas){
    let result = '';
    const charList = document.getElementById('charlist');
    datas.forEach(el=>{
        result += 
        `<div class="row row-cols-1 row-cols-md-3 g-4">
        <d class="col">
          <div class="card h-100">
            <img src="${el.flags.png}" class="card-img-top" alt="...">
            <div class="card-body">
              <h5 class="card-title">${el.name.common}</h5>
              <p class="card-text">${el.flags.alt}</p>
            </div>
            <a href="#" class="btn btn-primary">Detail</a>
          </div>
      </div>`
        // `<img src="${el.flags.png}" class="card-img-top" alt="...">
        // <div class="card-body">
        //   <h5 class="card-title">${el.name.common}</h5>
        //   <p class="card-text">${el.flags.alt}</p>
        //   <a href="#" class="btn btn-primary">Detail</a>
        // </div>`
    })
    charList.innerHTML = result;
}

toHtml();

