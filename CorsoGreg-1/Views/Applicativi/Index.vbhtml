@ModelType IEnumerable(Of CorsoGreg_1.ViewModel.ApplicativoViewModel)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table b-color-black table-bordered ">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.id)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.idCliente)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.iddirettiva)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DescrizioneProgramma)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.subdirectory)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DescrizioneAssembly)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.annullato)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Note)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.old_collegamento)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.visibile)
        </th>
        <th></th>
    </tr>
    <tr>
        @Using Ajax.BeginForm("searchSocieta", "Societa", New AjaxOptions With {
                                                      .HttpMethod = "GET",
                                                      .UpdateTargetId = "listaContainer",
                                                      .InsertionMode = InsertionMode.Replace})
            @<td>
                @Html.TextBox("ID", "", New With {.class = "form-control"})
            </td>
            @<td>
                @Html.TextBox("IDCliente", "", New With {.class = "form-control"})
            </td>
            @<td>
                @Html.TextBox("IDDirettiva", "", New With {.class = "form-control"})
            </td>
            @<td>
                @Html.TextBox("DescrizioneProgramma", "", New With {.class = "form-control"})
            </td>
            @<td>
                @Html.TextBox("subdirectory", "", New With {.class = "form-control"})
            </td>
            @<td>
                @Html.TextBox("DescrizioneAssembly", "", New With {.class = "form-control"})
            </td>
            @<td>
                <input type="text" name="annullato" class = "form-control" />
            </td>
            @<td>
                <input type="text" name="note"  class = "form-control"/>
            </td>
            @<td>
                <input type="text" name="old_collegamento" class = "form-control" />
            </td>
            @<td>
                <input type="text" name="visibile" class = "form-control" />
            </td>
            @<td>
                <button type="submit" id="btnRicerca">Applica Filtri</button>
            </td>

        End Using
    </tr>
    @For Each item In Model
        @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.id)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.idCliente)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.iddirettiva)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.DescrizioneProgramma)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.subdirectory)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.DescrizioneAssembly)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.annullato)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Note)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.old_collegamento)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.visibile)
    </td>
    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = item.id})
        @*|
            @Html.ActionLink("Details", "Details", New With {.id = item.id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id})*@
    </td>
</tr>
    Next

</table>
