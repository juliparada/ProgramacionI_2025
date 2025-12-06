// Variables y funciones compartidas por las parciales
var formActivo = '';

// Obtiene alumnos (usa el endpoint que ya tienes)
async function obtenerAlumnos(buscar = '') {
    try {
        const url = `/api/Alumnos/buscar?buscar=${encodeURIComponent(buscar || '')}`;
        const resp = await fetch(url, { method: 'GET', headers: { 'Content-Type': 'application/json' } });
        if (!resp.ok) return [];
        return await resp.json();
    } catch (err) {
        console.error('obtenerAlumnos error:', err);
        return [];
    }
}

// Obtiene periodos
async function obtenerPeriodos() {
    try {
        const resp = await fetch('/api/Periodos', { method: 'GET', headers: { 'Content-Type': 'application/json' } });
        if (!resp.ok) return [];
        return await resp.json();
    } catch (err) {
        console.error('obtenerPeriodos error:', err);
        return [];
    }
}

// Mensajes (opcional)
function mostrarError(msg) {
    if (window.alertify) alertify.error(msg);
    else console.error(msg);
}