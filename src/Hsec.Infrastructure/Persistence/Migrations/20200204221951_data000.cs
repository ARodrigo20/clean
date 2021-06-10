using Microsoft.EntityFrameworkCore.Migrations;

namespace Hsec.Infrastructure.Persistence.Migrations
{
    public partial class data000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_ActividadRelacionadaCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_ActoSubEstándarCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_CorreccionCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_ErrorObsCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_EstadoCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_HHARelacionadaCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionComportamientos_TObservaciones_ObservacionCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_StopWorkCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_ActividadRelacionadaCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_CondicionSubEstandarCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_CorreccionCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_HHARelacionadaCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionCondiciones_TObservaciones_ObservacionCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_StopWorkCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionIteracciones_TObservaciones_ObservacionCorrelativo",
                table: "TObservacionIteracciones");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_ActividadRelacionadaCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_ErrorObsCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_EstadoObsCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_HHARelacionadaCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionTareas_TObservaciones_ObservacionCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_StopWorkCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionTareas_ActividadRelacionadaCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionTareas_ErrorObsCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionTareas_EstadoObsCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionTareas_HHARelacionadaCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionTareas_ObservacionCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionTareas_StopWorkCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionIteracciones_ObservacionCorrelativo",
                table: "TObservacionIteracciones");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionCondiciones_ActividadRelacionadaCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionCondiciones_CondicionSubEstandarCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionCondiciones_CorreccionCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionCondiciones_HHARelacionadaCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionCondiciones_ObservacionCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionCondiciones_StopWorkCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionComportamientos_ActividadRelacionadaCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionComportamientos_ActoSubEstándarCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionComportamientos_CorreccionCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionComportamientos_ErrorObsCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionComportamientos_EstadoCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionComportamientos_HHARelacionadaCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionComportamientos_ObservacionCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropIndex(
                name: "IX_TObservacionComportamientos_StopWorkCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropColumn(
                name: "ActividadRelacionadaCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropColumn(
                name: "ErrorObsCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropColumn(
                name: "EstadoObsCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropColumn(
                name: "HHARelacionadaCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropColumn(
                name: "ObservacionCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropColumn(
                name: "StopWorkCorrelativo",
                table: "TObservacionTareas");

            migrationBuilder.DropColumn(
                name: "ObservacionCorrelativo",
                table: "TObservacionIteracciones");

            migrationBuilder.DropColumn(
                name: "ActividadRelacionadaCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropColumn(
                name: "CondicionSubEstandarCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropColumn(
                name: "CorreccionCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropColumn(
                name: "HHARelacionadaCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropColumn(
                name: "ObservacionCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropColumn(
                name: "StopWorkCorrelativo",
                table: "TObservacionCondiciones");

            migrationBuilder.DropColumn(
                name: "ActividadRelacionadaCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropColumn(
                name: "ActoSubEstándarCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropColumn(
                name: "CorreccionCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropColumn(
                name: "ErrorObsCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropColumn(
                name: "EstadoCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropColumn(
                name: "HHARelacionadaCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropColumn(
                name: "ObservacionCorrelativo",
                table: "TObservacionComportamientos");

            migrationBuilder.DropColumn(
                name: "StopWorkCorrelativo",
                table: "TObservacionComportamientos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActividadRelacionadaCorrelativo",
                table: "TObservacionTareas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ErrorObsCorrelativo",
                table: "TObservacionTareas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoObsCorrelativo",
                table: "TObservacionTareas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHARelacionadaCorrelativo",
                table: "TObservacionTareas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObservacionCorrelativo",
                table: "TObservacionTareas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StopWorkCorrelativo",
                table: "TObservacionTareas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObservacionCorrelativo",
                table: "TObservacionIteracciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActividadRelacionadaCorrelativo",
                table: "TObservacionCondiciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CondicionSubEstandarCorrelativo",
                table: "TObservacionCondiciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorreccionCorrelativo",
                table: "TObservacionCondiciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHARelacionadaCorrelativo",
                table: "TObservacionCondiciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObservacionCorrelativo",
                table: "TObservacionCondiciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StopWorkCorrelativo",
                table: "TObservacionCondiciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActividadRelacionadaCorrelativo",
                table: "TObservacionComportamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActoSubEstándarCorrelativo",
                table: "TObservacionComportamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorreccionCorrelativo",
                table: "TObservacionComportamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ErrorObsCorrelativo",
                table: "TObservacionComportamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoCorrelativo",
                table: "TObservacionComportamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHARelacionadaCorrelativo",
                table: "TObservacionComportamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObservacionCorrelativo",
                table: "TObservacionComportamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StopWorkCorrelativo",
                table: "TObservacionComportamientos",
                type: "int",
                nullable: true);

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
                name: "IX_TObservacionIteracciones_ObservacionCorrelativo",
                table: "TObservacionIteracciones",
                column: "ObservacionCorrelativo");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_ActividadRelacionadaCorrelativo",
                table: "TObservacionComportamientos",
                column: "ActividadRelacionadaCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_ActoSubEstándarCorrelativo",
                table: "TObservacionComportamientos",
                column: "ActoSubEstándarCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_CorreccionCorrelativo",
                table: "TObservacionComportamientos",
                column: "CorreccionCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_ErrorObsCorrelativo",
                table: "TObservacionComportamientos",
                column: "ErrorObsCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_EstadoCorrelativo",
                table: "TObservacionComportamientos",
                column: "EstadoCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_HHARelacionadaCorrelativo",
                table: "TObservacionComportamientos",
                column: "HHARelacionadaCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionComportamientos_TObservaciones_ObservacionCorrelativo",
                table: "TObservacionComportamientos",
                column: "ObservacionCorrelativo",
                principalTable: "TObservaciones",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionComportamientos_TObsMaestros_StopWorkCorrelativo",
                table: "TObservacionComportamientos",
                column: "StopWorkCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_ActividadRelacionadaCorrelativo",
                table: "TObservacionCondiciones",
                column: "ActividadRelacionadaCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_CondicionSubEstandarCorrelativo",
                table: "TObservacionCondiciones",
                column: "CondicionSubEstandarCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_CorreccionCorrelativo",
                table: "TObservacionCondiciones",
                column: "CorreccionCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_HHARelacionadaCorrelativo",
                table: "TObservacionCondiciones",
                column: "HHARelacionadaCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionCondiciones_TObservaciones_ObservacionCorrelativo",
                table: "TObservacionCondiciones",
                column: "ObservacionCorrelativo",
                principalTable: "TObservaciones",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionCondiciones_TObsMaestros_StopWorkCorrelativo",
                table: "TObservacionCondiciones",
                column: "StopWorkCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionIteracciones_TObservaciones_ObservacionCorrelativo",
                table: "TObservacionIteracciones",
                column: "ObservacionCorrelativo",
                principalTable: "TObservaciones",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_ActividadRelacionadaCorrelativo",
                table: "TObservacionTareas",
                column: "ActividadRelacionadaCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_ErrorObsCorrelativo",
                table: "TObservacionTareas",
                column: "ErrorObsCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_EstadoObsCorrelativo",
                table: "TObservacionTareas",
                column: "EstadoObsCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_HHARelacionadaCorrelativo",
                table: "TObservacionTareas",
                column: "HHARelacionadaCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionTareas_TObservaciones_ObservacionCorrelativo",
                table: "TObservacionTareas",
                column: "ObservacionCorrelativo",
                principalTable: "TObservaciones",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TObservacionTareas_TObsMaestros_StopWorkCorrelativo",
                table: "TObservacionTareas",
                column: "StopWorkCorrelativo",
                principalTable: "TObsMaestros",
                principalColumn: "Correlativo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
