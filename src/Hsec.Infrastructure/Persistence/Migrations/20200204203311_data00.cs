using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hsec.Infrastructure.Persistence.Migrations
{
    public partial class data00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItems");

            migrationBuilder.CreateTable(
                name: "TObservaciones",
                columns: table => new
                {
                    Correlativo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreadoPor = table.Column<string>(nullable: true),
                    Creado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(nullable: true),
                    Modificado = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    CodObservacion = table.Column<string>(nullable: true),
                    CodTabla = table.Column<string>(nullable: true),
                    CodPosicionGer = table.Column<string>(nullable: true),
                    CodPosicionSup = table.Column<string>(nullable: true),
                    CodAreaHsec = table.Column<string>(nullable: true),
                    CodTipoObservacion = table.Column<int>(nullable: false),
                    CodSubTipoObs = table.Column<string>(nullable: true),
                    CodNivelRiesgo = table.Column<string>(nullable: true),
                    CodObservadoPor = table.Column<string>(nullable: true),
                    FechaObservacion = table.Column<DateTime>(nullable: true),
                    HoraObservacion = table.Column<string>(nullable: true),
                    CodUbicacion = table.Column<string>(nullable: true),
                    CodSubUbicacion = table.Column<string>(nullable: true),
                    CodUbicacionEspecifica = table.Column<string>(nullable: true),
                    DesUbicacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObservaciones", x => x.Correlativo);
                });

            migrationBuilder.CreateTable(
                name: "TObsMaestros",
                columns: table => new
                {
                    Correlativo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreadoPor = table.Column<string>(nullable: true),
                    Creado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(nullable: true),
                    Modificado = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    CodTabla = table.Column<string>(nullable: false),
                    DesTabla = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObsMaestros", x => x.Correlativo);
                });

            migrationBuilder.CreateTable(
                name: "TObservacionComportamientos",
                columns: table => new
                {
                    Correlativo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodObservacion = table.Column<string>(nullable: true),
                    CodTabla = table.Column<string>(nullable: true),
                    CompObservada = table.Column<string>(nullable: true),
                    CompAccionInmediata = table.Column<string>(nullable: true),
                    CodActiRelacionada = table.Column<int>(nullable: true),
                    CodEstado = table.Column<string>(nullable: true),
                    CodHha = table.Column<string>(nullable: true),
                    CodErrorObs = table.Column<string>(nullable: true),
                    CodActoSubEstandar = table.Column<string>(nullable: true),
                    CodStopWork = table.Column<string>(nullable: true),
                    CodCorreccion = table.Column<string>(nullable: true),
                    ObservacionCorrelativo = table.Column<int>(nullable: true),
                    CorreccionCorrelativo = table.Column<int>(nullable: true),
                    EstadoCorrelativo = table.Column<int>(nullable: true),
                    ActividadRelacionadaCorrelativo = table.Column<int>(nullable: true),
                    ErrorObsCorrelativo = table.Column<int>(nullable: true),
                    HHARelacionadaCorrelativo = table.Column<int>(nullable: true),
                    ActoSubEstándarCorrelativo = table.Column<int>(nullable: true),
                    StopWorkCorrelativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObservacionComportamientos", x => x.Correlativo);
                    table.ForeignKey(
                        name: "FK_TObservacionComportamientos_TObsMaestros_ActividadRelacionadaCorrelativo",
                        column: x => x.ActividadRelacionadaCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionComportamientos_TObsMaestros_ActoSubEstándarCorrelativo",
                        column: x => x.ActoSubEstándarCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionComportamientos_TObsMaestros_CorreccionCorrelativo",
                        column: x => x.CorreccionCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionComportamientos_TObsMaestros_ErrorObsCorrelativo",
                        column: x => x.ErrorObsCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionComportamientos_TObsMaestros_EstadoCorrelativo",
                        column: x => x.EstadoCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionComportamientos_TObsMaestros_HHARelacionadaCorrelativo",
                        column: x => x.HHARelacionadaCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionComportamientos_TObservaciones_ObservacionCorrelativo",
                        column: x => x.ObservacionCorrelativo,
                        principalTable: "TObservaciones",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionComportamientos_TObsMaestros_StopWorkCorrelativo",
                        column: x => x.StopWorkCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TObservacionCondiciones",
                columns: table => new
                {
                    Correlativo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodObservacion = table.Column<string>(nullable: true),
                    CodTabla = table.Column<string>(nullable: true),
                    CondObservada = table.Column<string>(nullable: true),
                    CondAccionInmediata = table.Column<string>(nullable: true),
                    CodActiRelacionada = table.Column<int>(nullable: true),
                    CodHha = table.Column<string>(nullable: true),
                    CodCondicionSubEstandar = table.Column<string>(nullable: true),
                    CodStopWork = table.Column<string>(nullable: true),
                    CodCorreccion = table.Column<string>(nullable: true),
                    ObservacionCorrelativo = table.Column<int>(nullable: true),
                    CorreccionCorrelativo = table.Column<int>(nullable: true),
                    ActividadRelacionadaCorrelativo = table.Column<int>(nullable: true),
                    HHARelacionadaCorrelativo = table.Column<int>(nullable: true),
                    CondicionSubEstandarCorrelativo = table.Column<int>(nullable: true),
                    StopWorkCorrelativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObservacionCondiciones", x => x.Correlativo);
                    table.ForeignKey(
                        name: "FK_TObservacionCondiciones_TObsMaestros_ActividadRelacionadaCorrelativo",
                        column: x => x.ActividadRelacionadaCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionCondiciones_TObsMaestros_CondicionSubEstandarCorrelativo",
                        column: x => x.CondicionSubEstandarCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionCondiciones_TObsMaestros_CorreccionCorrelativo",
                        column: x => x.CorreccionCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionCondiciones_TObsMaestros_HHARelacionadaCorrelativo",
                        column: x => x.HHARelacionadaCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionCondiciones_TObservaciones_ObservacionCorrelativo",
                        column: x => x.ObservacionCorrelativo,
                        principalTable: "TObservaciones",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionCondiciones_TObsMaestros_StopWorkCorrelativo",
                        column: x => x.StopWorkCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TObservacionIteracciones",
                columns: table => new
                {
                    Correlativo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodObsIteracion = table.Column<string>(nullable: true),
                    CodObservacion = table.Column<string>(nullable: true),
                    CodLiderPersona = table.Column<string>(nullable: true),
                    CodContratista = table.Column<string>(nullable: true),
                    EquipoInvolucrado = table.Column<string>(nullable: true),
                    DetalleComportamiento = table.Column<string>(nullable: true),
                    AccionesInmediatas = table.Column<string>(nullable: true),
                    IteraccionSeguridad = table.Column<string>(nullable: true),
                    OtroActividadRiesgo = table.Column<string>(nullable: true),
                    OtroComponente = table.Column<string>(nullable: true),
                    ActividadTareaObs = table.Column<string>(nullable: true),
                    CodStopWork = table.Column<string>(nullable: true),
                    ObservacionCorrelativo = table.Column<int>(nullable: true),
                    StopWorkCorrelativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObservacionIteracciones", x => x.Correlativo);
                    table.ForeignKey(
                        name: "FK_TObservacionIteracciones_TObservaciones_ObservacionCorrelativo",
                        column: x => x.ObservacionCorrelativo,
                        principalTable: "TObservaciones",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionIteracciones_TObsMaestros_StopWorkCorrelativo",
                        column: x => x.StopWorkCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TObservacionTareas",
                columns: table => new
                {
                    Correlativo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreadoPor = table.Column<string>(nullable: true),
                    Creado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(nullable: true),
                    Modificado = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    CodObservacion = table.Column<string>(nullable: true),
                    CodTabla = table.Column<string>(nullable: true),
                    TareaObservada = table.Column<string>(nullable: true),
                    Pet = table.Column<string>(nullable: true),
                    CodActiRelacionada = table.Column<int>(nullable: true),
                    CodHha = table.Column<string>(nullable: true),
                    CodErrorObs = table.Column<string>(nullable: true),
                    CodEstadoObs = table.Column<string>(nullable: true),
                    DesConclusiones = table.Column<string>(nullable: true),
                    DesConclusionesfeedback = table.Column<string>(nullable: true),
                    DesConclusionesProModi = table.Column<string>(nullable: true),
                    ComenRecoOpor = table.Column<string>(nullable: true),
                    CodStopWork = table.Column<string>(nullable: true),
                    ObservacionCorrelativo = table.Column<int>(nullable: true),
                    HHARelacionadaCorrelativo = table.Column<int>(nullable: true),
                    ActividadRelacionadaCorrelativo = table.Column<int>(nullable: true),
                    StopWorkCorrelativo = table.Column<int>(nullable: true),
                    EstadoObsCorrelativo = table.Column<int>(nullable: true),
                    ErrorObsCorrelativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObservacionTareas", x => x.Correlativo);
                    table.ForeignKey(
                        name: "FK_TObservacionTareas_TObsMaestros_ActividadRelacionadaCorrelativo",
                        column: x => x.ActividadRelacionadaCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionTareas_TObsMaestros_ErrorObsCorrelativo",
                        column: x => x.ErrorObsCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionTareas_TObsMaestros_EstadoObsCorrelativo",
                        column: x => x.EstadoObsCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionTareas_TObsMaestros_HHARelacionadaCorrelativo",
                        column: x => x.HHARelacionadaCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionTareas_TObservaciones_ObservacionCorrelativo",
                        column: x => x.ObservacionCorrelativo,
                        principalTable: "TObservaciones",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObservacionTareas_TObsMaestros_StopWorkCorrelativo",
                        column: x => x.StopWorkCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TObsISRegistroEncuestaMaestros",
                columns: table => new
                {
                    CodObsIteracion = table.Column<string>(nullable: false),
                    CodigoTipo = table.Column<string>(nullable: false),
                    CodDescripcion = table.Column<string>(nullable: false),
                    CreadoPor = table.Column<string>(nullable: true),
                    Creado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(nullable: true),
                    Modificado = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    TObservacionIteraccionCorrelativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObsISRegistroEncuestaMaestros", x => new { x.CodObsIteracion, x.CodigoTipo, x.CodDescripcion });
                    table.ForeignKey(
                        name: "FK_TObsISRegistroEncuestaMaestros_TObservacionIteracciones_TObservacionIteraccionCorrelativo",
                        column: x => x.TObservacionIteraccionCorrelativo,
                        principalTable: "TObservacionIteracciones",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TObsMiembrosEquipos",
                columns: table => new
                {
                    Correlativo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPersonaMiembro = table.Column<string>(nullable: true),
                    CodObsIteracion = table.Column<string>(nullable: true),
                    LiderEquipo = table.Column<int>(nullable: false),
                    ObservacionIteraccionCorrelativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObsMiembrosEquipos", x => x.Correlativo);
                    table.ForeignKey(
                        name: "FK_TObsMiembrosEquipos_TObservacionIteracciones_ObservacionIteraccionCorrelativo",
                        column: x => x.ObservacionIteraccionCorrelativo,
                        principalTable: "TObservacionIteracciones",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TObsTaComentarios",
                columns: table => new
                {
                    Correlativo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreadoPor = table.Column<string>(nullable: true),
                    Creado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(nullable: true),
                    Modificado = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    NroReferencia = table.Column<string>(nullable: false),
                    CodTipoComentario = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    TipoComentarioCorrelativo = table.Column<int>(nullable: true),
                    TareaCorrelativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObsTaComentarios", x => x.Correlativo);
                    table.ForeignKey(
                        name: "FK_TObsTaComentarios_TObservacionTareas_TareaCorrelativo",
                        column: x => x.TareaCorrelativo,
                        principalTable: "TObservacionTareas",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TObsTaComentarios_TObsMaestros_TipoComentarioCorrelativo",
                        column: x => x.TipoComentarioCorrelativo,
                        principalTable: "TObsMaestros",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TObsTaEtapaTareas",
                columns: table => new
                {
                    Correlativo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreadoPor = table.Column<string>(nullable: true),
                    Creado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(nullable: true),
                    Modificado = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    TObservacionTarea = table.Column<string>(nullable: false),
                    TituloEtapaTarea = table.Column<string>(nullable: true),
                    DescripcionEtapaTarea = table.Column<string>(nullable: true),
                    TareaCorrelativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObsTaEtapaTareas", x => x.Correlativo);
                    table.ForeignKey(
                        name: "FK_TObsTaEtapaTareas_TObservacionTareas_TareaCorrelativo",
                        column: x => x.TareaCorrelativo,
                        principalTable: "TObservacionTareas",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TObsTaRegistroEncuestas",
                columns: table => new
                {
                    NroDocReferencia = table.Column<string>(nullable: false),
                    CodTabla = table.Column<string>(nullable: false),
                    CodPregunta = table.Column<string>(nullable: false),
                    CreadoPor = table.Column<string>(nullable: true),
                    Creado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(nullable: true),
                    Modificado = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    CodRespuesta = table.Column<string>(nullable: true),
                    TareaCorrelativo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TObsTaRegistroEncuestas", x => new { x.NroDocReferencia, x.CodTabla, x.CodPregunta });
                    table.ForeignKey(
                        name: "FK_TObsTaRegistroEncuestas_TObservacionTareas_TareaCorrelativo",
                        column: x => x.TareaCorrelativo,
                        principalTable: "TObservacionTareas",
                        principalColumn: "Correlativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionComportamientos_ActividadRelacionadaCorrelativo",
                table: "TObservacionComportamientos",
                column: "ActividadRelacionadaCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionComportamientos_ActoSubEstándarCorrelativo",
                table: "TObservacionComportamientos",
                column: "ActoSubEstándarCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionComportamientos_CorreccionCorrelativo",
                table: "TObservacionComportamientos",
                column: "CorreccionCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionComportamientos_ErrorObsCorrelativo",
                table: "TObservacionComportamientos",
                column: "ErrorObsCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionComportamientos_EstadoCorrelativo",
                table: "TObservacionComportamientos",
                column: "EstadoCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionComportamientos_HHARelacionadaCorrelativo",
                table: "TObservacionComportamientos",
                column: "HHARelacionadaCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionComportamientos_ObservacionCorrelativo",
                table: "TObservacionComportamientos",
                column: "ObservacionCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionComportamientos_StopWorkCorrelativo",
                table: "TObservacionComportamientos",
                column: "StopWorkCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionCondiciones_ActividadRelacionadaCorrelativo",
                table: "TObservacionCondiciones",
                column: "ActividadRelacionadaCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionCondiciones_CondicionSubEstandarCorrelativo",
                table: "TObservacionCondiciones",
                column: "CondicionSubEstandarCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionCondiciones_CorreccionCorrelativo",
                table: "TObservacionCondiciones",
                column: "CorreccionCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionCondiciones_HHARelacionadaCorrelativo",
                table: "TObservacionCondiciones",
                column: "HHARelacionadaCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionCondiciones_ObservacionCorrelativo",
                table: "TObservacionCondiciones",
                column: "ObservacionCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionCondiciones_StopWorkCorrelativo",
                table: "TObservacionCondiciones",
                column: "StopWorkCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionIteracciones_ObservacionCorrelativo",
                table: "TObservacionIteracciones",
                column: "ObservacionCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionIteracciones_StopWorkCorrelativo",
                table: "TObservacionIteracciones",
                column: "StopWorkCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionTareas_ActividadRelacionadaCorrelativo",
                table: "TObservacionTareas",
                column: "ActividadRelacionadaCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionTareas_ErrorObsCorrelativo",
                table: "TObservacionTareas",
                column: "ErrorObsCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionTareas_EstadoObsCorrelativo",
                table: "TObservacionTareas",
                column: "EstadoObsCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionTareas_HHARelacionadaCorrelativo",
                table: "TObservacionTareas",
                column: "HHARelacionadaCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionTareas_ObservacionCorrelativo",
                table: "TObservacionTareas",
                column: "ObservacionCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObservacionTareas_StopWorkCorrelativo",
                table: "TObservacionTareas",
                column: "StopWorkCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObsISRegistroEncuestaMaestros_TObservacionIteraccionCorrelativo",
                table: "TObsISRegistroEncuestaMaestros",
                column: "TObservacionIteraccionCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObsMiembrosEquipos_ObservacionIteraccionCorrelativo",
                table: "TObsMiembrosEquipos",
                column: "ObservacionIteraccionCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObsTaComentarios_TareaCorrelativo",
                table: "TObsTaComentarios",
                column: "TareaCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObsTaComentarios_TipoComentarioCorrelativo",
                table: "TObsTaComentarios",
                column: "TipoComentarioCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObsTaEtapaTareas_TareaCorrelativo",
                table: "TObsTaEtapaTareas",
                column: "TareaCorrelativo");

            migrationBuilder.CreateIndex(
                name: "IX_TObsTaRegistroEncuestas_TareaCorrelativo",
                table: "TObsTaRegistroEncuestas",
                column: "TareaCorrelativo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TObservacionComportamientos");

            migrationBuilder.DropTable(
                name: "TObservacionCondiciones");

            migrationBuilder.DropTable(
                name: "TObsISRegistroEncuestaMaestros");

            migrationBuilder.DropTable(
                name: "TObsMiembrosEquipos");

            migrationBuilder.DropTable(
                name: "TObsTaComentarios");

            migrationBuilder.DropTable(
                name: "TObsTaEtapaTareas");

            migrationBuilder.DropTable(
                name: "TObsTaRegistroEncuestas");

            migrationBuilder.DropTable(
                name: "TObservacionIteracciones");

            migrationBuilder.DropTable(
                name: "TObservacionTareas");

            migrationBuilder.DropTable(
                name: "TObsMaestros");

            migrationBuilder.DropTable(
                name: "TObservaciones");

            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Creado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Done = table.Column<bool>(type: "bit", nullable: false),
                    ListId = table.Column<int>(type: "int", nullable: false),
                    Modificado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Reminder = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Id);
                });
        }
    }
}
