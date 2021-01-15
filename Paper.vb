const Engine = Matter.Engine;
const World = Matter.World;
const Bodies = Matter.Bodies;
const Body = Matter.Body;
var dustbinObj, paperObj, groungObj;
var World;

function preload(){
    paperObj = loadImage(paper.png);
    dustbinObj = loadImage(dustbingreen.png);
}

function setuo(){
    createCanvas(1600,700);
    rectMode(CENTER);

    engine = Engine.create();
    world = engine.world;
    dustbinObj = new dustbin(1200, 650);
    paperObj = new paper(200, 450, 40);
    groundObj = new ground(widht/2, 670, 300, 20);


    var render = Render.create({
        element: document.body,
        engine: engine,
    } 
        options: {
            width: 1200,
            height: 760,
            wireframes: false
        }
       );

       Engine.run(engine);
       Render.run(render)
}

function draw(){
    Engine.update(engine);
    dustbinObj.display();
    paperObj.display();
}