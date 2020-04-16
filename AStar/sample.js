function removeFromArray(arr, element) {    
    for(let i = arr.length - 1; i >= 0; i--) {
        if(arr[i] == element) {
            arr.splice(i, 1);
        }
    }
}
function heuristic(a, b) {
    var d = dist(a.i, a.j, b.i, b.j);
    return d;
}

var cols = 50;
var rows = 50;
var grid = new Array(cols);

var openSet = [];
var closedSet = [];
var start;
var end;
var path = [];
var w, h;
var alrt = 1;

function Spot(i,j) {
    this.i = i;
    this.j = j;
    this.h = 0;
    this.g = 0;
    this.f = 0;

    this.neighbors = [];
    this.previous = undefined;

    this.wall = false;

    if(random(1) < 0.3) {
        this.wall = true;
    }
        

    this.show = function(color) {
        fill(color);
        if (this.wall) {
            fill(0);
        }
        stroke(0); 
        rect(this.i * w, this.j * h, w - 1, h - 1);
    }
    this.addNeighbors = function(grid) {
        if(i < cols -1) {
            this.neighbors.push(grid[this.i + 1][j]);
        }
        if(i > 0) {
            this.neighbors.push(grid[this.i - 1][j]);
        }
        if(j < rows - 1) {
            this.neighbors.push(grid[this.i][j + 1]);
        }
        if(j > 0) {
            this.neighbors.push(grid[this.i][j - 1]);
        }
    }
}

function setup() {
    createCanvas(600,600);
    console.log('A*');

    w = width / cols;
    h = height / rows;

    // make 2D array
    for (let i = 0; i < cols; i++) {
        grid[i] = new Array(rows);        
    }
    
    for (let i = 0; i < cols; i++) {
        for(let j = 0; j < rows; j++) {
            grid[i][j] = new Spot(i,j);
        }       
    }
    
    for (let i = 0; i < cols; i++) {
        for(let j = 0; j < rows; j++) {
            grid[i][j].addNeighbors(grid);
        }       
    }
    
    start = grid[0][0];
    start.show(color(0,255,0));
    end = grid[cols-1][rows-1];
    end.show(color(255,0,0));
    start.wall = false;
    end.wall = false;

    openSet.push(start);

    console.log(grid);
    
}
function draw() {
    if (alrt == 2) {
        alert("A* Algorithm is going to find path,\r\nDo you want to Start ?");
        alrt = 3;
    }
    if (openSet.length > 0) {
        
        // keep going
        var winner = 0;
        for(let i = 0; i < openSet.length; i++) {
            if(openSet[i].f < openSet[winner].f) {
                winner = i;
            }                
        }
        
        var current = openSet[winner];

        if(current === end) {            
            noLoop();
            console.log('DONE!');
        } else {
            removeFromArray(openSet, current);
            closedSet.push(current);
            
            var neighbors = current.neighbors;
            for(let i = 0; i < neighbors.length; i++) {
                var neighbor = neighbors[i];
                if(!closedSet.includes(neighbor) && !neighbor.wall) {
                    var tempG = current.g + 1;
                    if(openSet.includes(neighbor)) {
                        if(tempG < neighbor.g) {
                            neighbor.g = tempG;
                        }
                    }
                    else {
                        neighbor.g - tempG;
                        openSet.push(neighbor);
                    }

                    neighbor.h = heuristic(neighbor, end);
                    neighbor.f = neighbor.h + neighbor.g;
                    neighbor.previous = current;
                }
            }
        }
        
        
    } else {
        alert(":: THERE IS NO PATH ::");
    }
    background(0);

    for (let i = 0; i < cols; i++) {
        for(let j = 0; j < rows; j++) {
            grid[i][j].show(255);
        }       
    }
    
    for (let i = 0; i < openSet.length; i++) {
        openSet[i].show(color(0, 255, 0));
    }
    for (let i = 0; i < closedSet.length; i++) {
        closedSet[i].show(color(255, 0, 0));
    }
    var temp = current;
    path.push(temp);
    // while (temp.previous) {
    //     temp = temp.previous;
    //     path.push(temp);
    // }
    start.show(color(0,255,0));
    end.show(color(255,0,0));
    // for (let i = 0; i < path.length; i++) {
    //     path[i].show(color(0, 0, 255));
    // }
    if (alrt == 1) {
        alrt = 2;
    }
}