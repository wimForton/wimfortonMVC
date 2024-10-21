import * as THREE from "three";
var scene = new THREE.Scene();
var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);
var renderer = new THREE.WebGLRenderer();
renderer.setSize(window.innerWidth, window.innerHeight);
document.body.appendChild(renderer.domElement);
var geometry = new THREE.BoxGeometry(1, 1, 1);
var material = new THREE.MeshBasicMaterial({ color: 0x20b2aa });
var cube = new THREE.Mesh(geometry, material);
scene.add(cube);
var edges = new THREE.EdgesGeometry(geometry);
var line = new THREE.LineSegments(edges, new THREE.LineBasicMaterial({ color: 0x000000 }));
scene.add(line);
camera.position.z = 5;
camera.position.y = -1;
function Reset() {
    geometry.setSize(1, 1, 1);
}
function animate() {
    requestAnimationFrame(animate);
    cube.rotation.x += 0.01;
    cube.rotation.y += 0.01;
    line.rotation.x += 0.01;
    line.rotation.y += 0.01;
    renderer.render(scene, camera);
}
animate();
//# sourceMappingURL=ThreejsScene.js.map