:root {
  --bg:#0b0b0b; --card:#111; --muted:#cfcfcf; --text:#f5f5f5;
  --brand:#7c3aed; --brand-2:#22d3ee; --accent:#10b981; --border:#262626;
}

* { box-sizing: border-box; }
html, body { height: 100%; margin: 0; font-family: Inter, sans-serif; background: var(--bg); color: var(--text); }
a { color: inherit; text-decoration: none; }
img { max-width: 100%; display: block; }
.container { width:min(1200px, 92vw); margin:0 auto; }

/* Header */
header { position:sticky; top:0; z-index:50; background:linear-gradient(180deg, rgba(0,0,0,.75), rgba(0,0,0,.3) 80%, transparent) }
.topbar { margin:12px auto; border:1px solid var(--border); border-radius:18px;
  backdrop-filter:saturate(1.2) blur(6px); background:rgba(18,18,18,.85);
  display:flex; align-items:center; justify-content:space-between; padding:10px 14px; }
.brand { display:flex; align-items:center; gap:10px; }
.brand img { height:48px; width:auto; }
.brand strong { font-weight:800; letter-spacing:.5px; }
.menu-btn { border:1px solid var(--border); background:#161616; color:var(--text);
  padding:10px 14px; border-radius:12px; cursor:pointer; font-weight:600; display:inline-flex; align-items:center; gap:8px; }
.menu-btn:active { transform:translateY(1px); }

/* Slider */
.slider { position: relative; overflow: hidden; border-radius: 14px; border: 1px solid var(--border);
  margin: 16px auto 28px; max-width: 100%; aspect-ratio: 16/9; background:#000; }
.slides { display: flex; transition: transform 0.6s ease; height: 100%; }
.slides img { flex: 1 0 100%; object-fit: cover; height: 100%; }
.nav { position: absolute; top: 50%; transform: translateY(-50%); background: rgba(0,0,0,.5); color: #fff; border: none; font-size: 1.5rem;
  padding: 6px 10px; cursor: pointer; border-radius: 6px; }
.nav.prev { left: 10px; }
.nav.next { right: 10px; }
.nav:hover { background: rgba(0,0,0,.7); }

/* Seções */
section { padding:28px 0; }
.section-card { border:1px solid var(--border); border-radius:14px; background:var(--card); padding:18px; }
h2 { margin:0 0 8px 0; font-size: clamp(1.2rem, 2.5vw, 1.6rem); }
p { color:var(--muted); line-height:1.6; }

/* Grid de serviços */
.grid { display:grid; gap:16px; }
.grid.cards { grid-template-columns: repeat(auto-fit, minmax(230px,1fr)); }
.card { border:1px solid var(--border); border-radius:14px; overflow:hidden; background:#0f0f0f; display:flex; flex-direction:column; }
.card img { aspect-ratio: 16/9; object-fit: cover; }
.card .content { padding:12px 14px; display:flex; flex-direction:column; gap:8px; }
.btn { display:inline-flex; align-items:center; justify-content:center; gap:8px;
  border:1px solid var(--border); padding:10px 12px; border-radius:12px; font-weight:700; cursor:pointer; background:#161616; color:#f5f5f5; }
.btn:hover { filter:brightness(1.06); }
.btn.brand { background:linear-gradient(90deg, var(--brand), var(--brand-2)); border-color:transparent; }

/* CTA */
.cta { display:grid; gap:18px; align-items:center; grid-template-columns: 1.2fr .8fr;
  border:1px solid var(--border); border-radius:14px; padding:18px; background:radial-gradient(1200px 200px at 10% -20%, rgba(124,58,237,.2), transparent 60%), var(--card); }
.cta h3 { margin:0; font-size: clamp(1.25rem, 3vw, 1.8rem); }
.cta-legend { color:var(--muted); }
.cta-media { border-radius:10px; overflow:hidden; border:1px solid var(--border); }
.cta-media img { display:block; width:100%; height:auto; object-fit:cover; }
@media (max-width: 820px) { .cta{grid-template-columns: 1fr} }

/* Botão fixo WhatsApp */
.floating { position:fixed; right:14px; bottom:14px; z-index:70; }
.floating .btn { box-shadow:0 10px 30px rgba(0,0,0,.5); background:#25d366; border-color:#1ebe5b; color:#fff; }

/* Footer */
footer { background: var(--card); padding: 30px 20px 0; color: var(--text); font-size: 0.85rem; }
.footer-grid { display: grid; grid-template-columns: repeat(auto-fit, minmax(180px, 1fr)); gap: 20px; max-width: 1100px; margin: auto; text-align: left; }
.footer-card { padding: 5px; }
.footer-brand { display: flex; align-items: center; gap: 8px; margin-bottom: 10px; }
.footer-brand img { height: 182px; }
.footer-card h4 { margin: 10px 0 8px; font-size: 0.95rem; color: var(--brand); }
.footer-card p, .footer-card li { margin: 4px 0; color: #bbb; font-size: 0.85rem; line-height: 1.4; }
.socials { margin-top: 10px; display: flex; gap: 10px; }
.socials img { width: 18px; height: 18px; opacity: 0.8; transition: opacity .3s; }
.socials img:hover { opacity: 1; }
.copy { margin-top: 20px; text-align: center; font-size: 0.75rem; color: #aaa;
  border-top: 1px solid var(--border); padding: 10px 0; }
@media (min-width: 900px) {
  footer { font-size: 0.8rem; }
  .footer-card h4 { font-size: 0.9rem; }
}

/* Drawer */
.drawer { position:fixed; inset:0; display:none; z-index:100; }
.drawer.active { display:block; }
.drawer .backdrop { position:absolute; inset:0; background:rgba(0,0,0,.6); }
.drawer .panel { position:absolute; right:0; top:0; bottom:0; width:min(420px, 88vw); background:#0f0f0f;
  border-left:1px solid var(--border); padding:18px; overflow:auto; }
.drawer .panel h4 { margin:0 0 10px 0; }
.nav-list { display:grid; gap:8px; }
.nav-list a { padding:12px 14px; border:1px solid var(--border); border-radius:12px; background:#121212; font-weight:600; }
