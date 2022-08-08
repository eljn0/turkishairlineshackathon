ymaps.ready(init);


var newLocal = '</a>', placemarks = [ 
   

   
    { latitude: 41.0055005, 
        longitude: 28.7319869,
        hintContent: '<div class="map__hint"> <img class="map__burger-img" src="/rollimg/istanbul.jpg" alt="Бургер"/><div class="map-essay">Istanbul,Turkey</div></div>',
        balloonContent: [
            '<div class="map__balloon">',
            '<a href="https://www.turkishairlines.com/en-us/flights/flights-to-istanbul/">',
            '<img class="map__burger-img" src="/rollimg/istanbul.jpg" alt="Бургер"/>',
            '</a>',
            '<div class="map-essay">',
            '<a href="https://earth.google.com/web/@41.0132482,28.9832781,49.40287251a,0d,60y,331.87279646h,98.85943367t,0r/data=CjASLhIgNWI4N2YzZDQzMWY3MTFlOGFiNTdlOWViNmZhZTZkNWYiCmdjc19pdGluXzEiMAosQUYxUWlwTkJhdGZiNXlsSEdQcEpRaWwxQlpFU2k2UDFSVXVhQW4zaGs5TVEQBQ">',
            'Explore Istanbul with 3D VR tour!',
            '</a>',
            '<hr>',
            'Istanbul, Turkey',
            '<hr>',
            '<a href="https://www.turkishairlines.com/en-us/flights/flights-to-istanbul/">',
            'Ticket Prices for Istanbul',
            '</a>',
            '</div>',
            '</div>'
        ]
    },
    {
        latitude: 40.4381311, 
        longitude: -3.8196227,
        hintContent: '<div class="map__hint"> <a href="https://www.turkishairlines.com/en-us/flights/city/from-istanbul-to-madrid-flights/"><img class="map__burger-img" src="/rollimg/madrid.jpg" alt="Бургер"/></a> <div class="map-essay">Madrid, Spain</div></div>',
        balloonContent: [
            '<div class="map__balloon">',
            '<a href="https://www.turkishairlines.com/en-us/flights/city/from-istanbul-to-madrid-flights/">',
            '<img class="map__burger-img" src="/rollimg/madrid.jpg" alt="Бургер"/>',
            '</a>',
            '<div class="map-essay">',
            '<a href="https://earth.google.com/web/@40.41537285,-3.70734656,649.43916016a,193.89655324d,35y,30.96379176h,39.96502553t,0r/data=CjASLhIgZjljNjY4MDdmNTU0MTFlNzlkYTA3OTQ5NTI5ZGQ0MmIiCmdjc19pdGluXzE">',
            'Explore Madrid with 3D VR tour!',
            '</a>',
            '<hr>',
            'Madrid, Spain',
            '<hr>',
            '<a href="https://www.turkishairlines.com/en-us/flights/city/from-istanbul-to-madrid-flights/">',
            'Ticket Prices for Madrid',
            '</a>',
            '</div>',
            '</div>'
        ]
    },
    {
        latitude: 55.5815244,
        longitude: 36.8251014,
        hintContent: '<div class="map__hint"> <a href="https://www.turkishairlines.com/en-tr/flights/flights-to-moscow/"><img class="map__burger-img" src="/rollimg/moscow.jpg" alt="Бургер"/></a> <div class="map-essay">Moscow, Russia</div></div>',
        balloonContent: [
            '<div class="map__balloon">',
            '<a href="https://www.turkishairlines.com/en-tr/flights/flights-to-moscow/">',
            '<img class="map__burger-img" src="/rollimg/moscow.jpg" alt="Бургер"/>',
            '</a>',
            '<div class="map-essay">',
            '<a href="https://earth.google.com/web/@55.7601335,37.6186486,143.05862413a,563.30460272d,35y,0h,45t,0r/data=ChEaDwoJL20vMDJtOXExGAIgASgC">',
            'Explore Moscow with 3D VR tour!',
            '</a>',
            '<hr>',
            'Moscow, Russia',
            '<hr>',
            '<a href="https://www.turkishairlines.com/en-tr/flights/flights-to-moscow/">',
            'Ticket Prices for Moscow',
            '</a>',
            '</div>',
            '</div>'
        ]
    },
    {
        latitude: 51.5287352,
        longitude: -0.3817841,
        hintContent: '<div class="map__hint"> <a href="https://www.turkishairlines.com/en-tr/flights/flights-to-london/"><img class="map__burger-img" src="/rollimg/london.jpg" alt="Бургер"/></a> <div class="map-essay">London, United Kingdom</div></div>',
        balloonContent: [
            '<div class="map__balloon">',
            '<a href="https://www.turkishairlines.com/en-tr/flights/flights-to-london/">',
            '<img class="map__burger-img" src="/rollimg/london.jpg" alt="Бургер"/>',
            '</a>',
            '<div class="map-essay">',
            '<a href="https://earth.google.com/web/@51.50528362,-0.07496725,-0.49489163a,556.79d,35y,-31.297h,43.413t,0r/data=CjASLhIgZjUyN2NhYzIwNDRkMTFlN2E1YTMwMTQzMDUyMWMyZDQiCmdjc19pdGluXzE">',
            'Explore London with 3D VR tour!',
            '</a>',
            '<hr>',
            'London, United Kingdom',
            '<hr>',
            '<a href="https://www.turkishairlines.com/en-tr/flights/flights-to-london/">',
            'Ticket Prices for London',
            '</a>',
            '</div>',
            '</div>'
        ]
    },
    {
        latitude: 48.8589466,
        longitude: 2.2769949,
        hintContent: '<div class="map__hint"> <a href="https://www.turkishairlines.com/en-tr/flights/flights-to-paris/"><img class="map__burger-img" src="/rollimg/paris.jpg" alt="Бургер"/></a> <div class="map-essay">Paris, France</div></div>',
        balloonContent: [
            '<div class="map__balloon">',
            '<a href="https://www.turkishairlines.com/en-tr/flights/flights-to-paris/">',
            '<img class="map__burger-img" src="/rollimg/paris.jpg" alt="Бургер"/>',
            '</a>',
            '<div class="map-essay">',
            '<a href="https://earth.google.com/web/@48.86564757,2.32189801,24.12911237a,588.1d,35y,29.861h,76.101t,0r/data=CjASLhIgYWNiNWRhZWU1NGZlMTFlNjkzMTJlMzFmYThiMjE3ZTgiCmdjc19pdGluXzE">',
            'Explore Paris with 3D VR tour!',
            '</a>',
            '<hr>',
            'Paris, France',
            '<hr>',
            '<a href="https://www.turkishairlines.com/en-tr/flights/flights-to-paris/">',
            'Ticket Prices for Paris',
            '</a>',
            '</div>',
            '</div>'
        ]
    },
    {
        latitude: 45.2502975,
        longitude: -76.0804467,
        hintContent: '<div class="map__hint"> <a href="https://www.turkishairlines.com/en-tr/flights/flights-to-ottawa/"><img class="map__burger-img" src="/rollimg/ottawa.jpg" alt="Бургер"/></a> <div class="map-essay">Ottawa, Canada</div></div>',
        balloonContent: [
            '<div class="map__balloon">',
            '<a href="https://www.turkishairlines.com/en-tr/flights/flights-to-ottawa/">',
            '<img class="map__burger-img" src="/rollimg/ottawa.jpg" alt="Бургер"/>',
            '</a>',
            '<div class="map-essay">',
            '<a href="https://earth.google.com/web/@45.41731405,-75.71698852,64.50949097a,0d,60y,49.45127518h,89.18290612t,0r/data=CjASLhIgMDg2MGY4MmVjNWRlMTFlOGE4NGMzZmRiNjFkNTMyYmIiCmdjc19pdGluXzEiGgoWQVkteVc5amNVNU9keW01eW5YQ0ZKdxAC">',
            'Explore Ottawa with 3D VR tour!',
            '</a>',
            '<hr>',
            'Ottawa, Canada',
            '<hr>',
            '<a href="https://www.turkishairlines.com/en-tr/flights/flights-to-ottawa/">',
            'Ticket Prices for Ottawa',
            '</a>',
            '</div>',
            '</div>'
        ]
    },
    
    {
        latitude: 40.6976701,
        longitude: -74.2598737,
        hintContent: '<div class="map__hint"> <a href="https://www.turkishairlines.com/en-us/flights/flights-to-new-york/"><img class="map__burger-img" src="/rollimg/nyc.jpg" alt="Бургер"/></a> <div class="map-essay">New York City, USA</div></div>',
        balloonContent: [
            '<div class="map__balloon">',
            '<a href="https://www.turkishairlines.com/en-us/flights/flights-to-new-york/">',
            '<img class="map__burger-img" src="/rollimg/nyc.jpg" alt="Бургер"/>',
            '</a>',
            '<div class="map-essay">',
            '<a href="https://earth.google.com/web/@40.75273896,-73.9772294,11.32608418a,446.28d,35y,0h,38.094t,0r/data=CjASLhIgNDJlYzQwMDAwOWFkMTFlNzk3ZDQ0YjEzZjFjNTQwMDYiCmdjc19pdGluXzE">',
            'Explore NYC with 3D VR tour!',
            '</a>',
            '<hr>',
            'New York City, USA',
            '<hr>',
            '<a href="https://www.turkishairlines.com/en-us/flights/flights-to-new-york/">',
            'Ticket Prices for NYC',
            '</a>',
            '</div>',
            '</div>'
        ]
    },  
    {
        latitude: 25.0763815,
        longitude: 54.9472875,
        hintContent: '<div class="map__hint"> <a href="https://www.turkishairlines.com/en-us/flights/flights-to-dubai/"><img class="map__burger-img" src="/rollimg/dubai.jpg" alt="Бургер"/></a> <div class="map-essay">Dubai, UAE</div></div>',
        balloonContent: [
            '<div class="map__balloon">',
            '<a href="https://www.turkishairlines.com/en-us/flights/flights-to-dubai/">',
            '<img class="map__burger-img" src="/rollimg/dubai.jpg" alt="Бургер"/>',
            '</a>',
            '<div class="map-essay">',
            '<a href="https://earth.google.com/web/@40.75273896,-73.9772294,13.4105928a,446.28d,35y,0h,38.094t,0r/data=CjASLhIgOGFiODQ3N2EwZGQ0MTFlOGI2MmY1ZDBhODk4N2QxNTIiCmdjc19pdGluXzU">',
            'Explore Dubai with 3D VR tour!',
            '</a>',
            '<hr>',
            'Dubai, UAE',
            '<hr>',
            '<a href="https://www.turkishairlines.com/en-us/flights/flights-to-dubai/">',
            'Ticket Prices for Dubai',
            '</a>',
            '</div>',
            '</div>'
        ]
    }, 
       
    {
        latitude:-13.6571599,
        longitude:-69.718235,
        hintContent: '<div class="map__hint"> <a href="https://www.turkishairlines.com/en-us/flights/country/brazil/"><img class="map__burger-img" src="/rollimg/brazil.jpg" alt="Бургер"/></a> <div class="map-essay">Brasilia, Brazil</div></div>',
        balloonContent: [
            '<div class="map__balloon">',
            '<a href="https://www.turkishairlines.com/en-us/flights/country/brazil/">',
            '<img class="map__burger-img" src="/rollimg/brazil.jpg" alt="Бургер"/>',
            '</a>',
            '<div class="map-essay">',
            '<a href="https://earth.google.com/web/@25.1167241,55.19615985,14.30277481a,223.7588388d,60y,-125.33076913h,87.46201079t,0r/data=CjASLhIgNTNlMWFhZmEwNjkyMTFlODg3YzBiZjEwYTJhYmJlNGQiCmdjc19pdGluXzA">',
            'Explore Brasilia with 3D VR tour!',
            '</a>',
            '<hr>',
            'Brasilia, Brazil',
            '<hr>',
            '<a href="https://www.turkishairlines.com/en-us/flights/country/brazil/">',
            'Ticket Prices for Brasilia',
            '</a>',
            '</div>',
            '</div>'
        ]
    },
    
    
    ],
    
 




    
    


/*],*/

    geoObjects= [];

function init() {
    var map = new ymaps.Map('map', {
        center: [35.1453829,-15.520818],
        zoom: 3,
        controls: ['zoomControl','default','routeButtonControl'],
        behaviors: ['drag']
    });

    for (var i = 0; i < placemarks.length; i++) {
            geoObjects[i] = new ymaps.Placemark([placemarks[i].latitude, placemarks[i].longitude],
            {
                hintContent: placemarks[i].hintContent,
                balloonContent: placemarks[i].balloonContent.join('')
            },
            {
                iconLayout: 'default#image',
                iconImageHref: '/img/sprite.png',
                iconImageSize: [45, 55],
                iconImageOffset: [-23, -57],
                iconImageClipRect: [[415, 0], [461, 57]]
            
            });
    }

    var clusterer = new ymaps.Clusterer({
        clusterIcons: [
            {
                href: '/img/pc1.png',
                size: [30, 30],
                offset: [-50,-50]
                
            }
        ],
        clusterIconContentLayout: null
    });

    map.geoObjects.add(clusterer);
    clusterer.add(geoObjects);}
    