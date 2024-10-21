import * as THREE from "three";

const scene = new THREE.Scene();
const camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);

const renderer = new THREE.WebGLRenderer();
renderer.setSize(window.innerWidth, window.innerHeight);
document.body.appendChild(renderer.domElement);
var myDataX = document.getElementById("myXdata").value;
var myDataY = document.getElementById("myYdata").value;
var myDataZ = document.getElementById("myZdata").value;
console.log("myDataX:  " + myDataX);
const geometry = new THREE.BoxGeometry(myDataX, myDataY, myDataZ);
const material = new THREE.MeshBasicMaterial({ color: 0x20b2aa });
const cube = new THREE.Mesh(geometry, material);
scene.add(cube);

const edges = new THREE.EdgesGeometry(geometry);
const line = new THREE.LineSegments(edges, new THREE.LineBasicMaterial({ color: 0x000000 }));
scene.add(line);

camera.position.z = 5;
camera.position.y = -1;

function Reset() {
    geometry.setSize(1, 1, 1);
    /*
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        document.getElementById("demo").innerHTML =
            this.responseText;
    }
    xhttp.open("GET", "ajax_info.txt");
    xhttp.send();*/
}
//$.ajax({
//    url: '@Url.Action("GetData")',
//    type: 'GET',
//    data: { myData: '@ViewData["MyData"]' },
//    success: function (data) {
//        console.log(data); // Output: "Ziggy Rafiq Blog Post"
//    }
//});


function animate() {
    requestAnimationFrame(animate);
    cube.rotation.x += 0.01;
    cube.rotation.y += 0.01;
    line.rotation.x += 0.01;
    line.rotation.y += 0.01;
    renderer.render(scene, camera);
}
animate();