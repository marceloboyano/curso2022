var movieRepository = (function () {
    var movies = [];
    var basePath = 'https://localhost:7078/api/';

    async function getAll ()
    {
        let moviesResponse = await fetch(basePath + 'movies?details=true'); 
        let moviesJSON = await moviesResponse.json();

        return moviesJSON;
    }


    return {
      getAll: getAll,
    };
  }());



  function login(username, password)
  {
    var url = `https://localhost:7078/api/auth/login?username=${username}&password=${password}`;

    fetch(url, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
          },
          body: ""
    }).then( data => {

        return data.json()
        
    }).then( token => {
        console.log(token)
    }), err => console.log(err)

  };


  function register(username, password, email)
  {
    var url = `https://localhost:7078/api/auth/register?username=${username}&password=${password}&email=${email}`

    fetch(url, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
          },
          body: ""
    }).then( data => {

        console.log(data);
        login(username, password);

    }, err => console.log(err))
  }


  
  
  register("marcelotest10", "123456", "bl10@gmail.com");
  
  


  var init = function init() {
    
    var movieContainer = document.getElementById("movieContainer");

    var movies =  movieRepository.getAll()
        .then((movies) => {
            console.log(movies)
        
        var liElements = "";

        movies.data.forEach(m =>
        {
            console.log(m);

            var genresHtml = "";
            var genres = `<span class="badge rounded-pill bg-success">#####</span>`;

            m.genders.forEach( g => {
                genresHtml += genres.replace("#####", g.name);
            })

            var charactersHtml = "";
            var characters = `<li class="mx-3">#####</li>`;

            m.characters.forEach( c => {
                charactersHtml += characters.replace("#####", c.name);
            })


            var htmlMovie = `
            <li class="list-group-item d-flex align-items-left li-card-container">
                        
            <div class="card text-white bg-light primary-card">
            <img class="card-img-top" src="https://via.placeholder.com/500" alt="Title">
            </div>
            
            
                    <div class="row m-3">

                        <div class="col-12">

                            <div class="card-body">
                                <h4 id="cardTitle-${m.moviesId}" class="card-title">${m.title}</h4>
                                <div id="cardGenres-${m.moviesId}">
                                    ${genresHtml}
                                </div>
                                    
                            </div>
                            
                        </div>
                        <div class="col-12 d-flex text-right">

                            <ul id="cardCharacters-${m.moviesId}" class="d-flex">
                                ${charactersHtml}
                            </ul>
                        </div>
                    </div>

            </li>
            <br>
            
            `
            
            
            
            liElements += htmlMovie;
            
            
        });
        
        movieContainer.innerHTML = liElements;
        
        
    }, err => console.log(err));

    // var cardTitle = document.getElementById("cardTitle");
    // var cardDescription = document.getElementById("cardDescription");
    // var cardGenres = document.getElementById("cardGenres");
    // var cardCharacters = document.getElementById("cardCharacters");

    
    
};

init();