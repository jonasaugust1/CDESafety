using CDESafety.Data;
using CDESafety.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseMySql(builder.Configuration.GetConnectionString("UsuarioConnection"), new MySqlServerVersion(new Version(8, 0))));

builder.Services.AddAuthorization();
builder.Services.AddScoped<AeronaveService, AeronaveService>();
builder.Services.AddScoped<AjudanteService, AjudanteService>();
builder.Services.AddScoped<ClienteService, ClienteService>();
builder.Services.AddScoped<CulturaService, CulturaService>();
builder.Services.AddScoped<EquipamentoService, EquipamentoService>();
builder.Services.AddScoped<PilotoService, PilotoService>();
builder.Services.AddScoped<PistaService, PistaService>();
builder.Services.AddScoped<ProdutoService, ProdutoService>();
builder.Services.AddScoped<PropriedadeService, PropriedadeService>();
builder.Services.AddScoped<RelatorioDeServicoService, RelatorioDeServicoService>();
builder.Services.AddScoped<UserService, UserService>();
builder.Configuration.AddUserSecrets<Program>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.MapControllers();

app.Run();
