#pragma checksum "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e71d2bdf434a1ee31c26154e8d10e5266faa8a"
// <auto-generated/>
#pragma warning disable 1591
namespace dassProjectBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using dassProjectBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using dassProjectBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/question")]
    public partial class Question : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "<style>\n    body,\n    html {\n      height: 100%;\n    }\n\n    h4 {\n      display: flex;\n      margin: auto;\n      align-items: center;\n      justify-content: center;\n    }\n\n    button:focus {\n    outline: none;\n}\n  </style>\n  ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid h-100 d-flex flex-column");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row flex-grow-1");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-sm-4 p-3 border");
            __builder.AddAttribute(8, "style", "background-color: #E4D6D2;");
            __builder.OpenElement(9, "h4");
            __builder.AddAttribute(10, "class", "question1");
            __builder.AddContent(11, 
#nullable restore
#line 27 "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor"
                               currentQuestion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n\n      \n      ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-sm-2 p-3 border");
            __builder.AddAttribute(15, "style", "background-color: blue;");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn shadown-none");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor"
                                                     () =>main(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<h4>Tidak Langsung</h4>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n\n      \n      ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-sm-2 p-3 border");
            __builder.AddAttribute(23, "style", "background-color: green ;");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn shadown-none");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor"
                                                     () =>main(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<h4>Sedikit atau Jarang Jarang</h4>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n\n      \n      ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-sm-2 p-3 border");
            __builder.AddAttribute(31, "style", "background-color: yellow;");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn shadown-none");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor"
                                                     () =>main(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "<h4>Banyak atau Kerapkali</h4>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n\n      \n      ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-sm-2 p-3 border");
            __builder.AddAttribute(39, "style", "background-color: red;");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn shadown-none");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor"
                                                     () =>main(3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "<h4>Sangat Banyak atau Sangat kerap</h4>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor"
       
  private string currentQuestion = "Saya dapati diri saya sukar ditenteramkan";
  private int i = 1;
  private int nomborSoalan = 1;
  private string soalan = "";
  private int skor = 0;

  private int keputusanStress = 0;
  private int keputusanAnzieti = 0;
  private int keputusanKemurungan = 0;


  private int[] soalanStress = {1,6,8,11,12,14,18};
  private int[] soalanAnzieti = {2,4,7,9,15,19,20};
  private int[] soalanKemurungan = {3,5,10,13,16,17,21};

  private string tahapStress = "";
  private string tahapAnzieti = "";
  private string tahapKemurungan = "";

  bool flag_endquestion = false;

  //check
  private void main(int nilai)
  {
    skor = nilai; 

    //sumup result
    if(flag_endquestion == false){
      if(soalanStress.Contains(nomborSoalan)){
        if(skor == 0){
          keputusanStress = keputusanStress + skor;
        }else if(skor == 1){
          keputusanStress = keputusanStress + skor;
        }else if(skor == 2){
          keputusanStress = keputusanStress + skor;
        }else if(skor == 3){
          keputusanStress = keputusanStress + skor;
        }
      }

      if(soalanAnzieti.Contains(nomborSoalan)){
        if(skor == 0){
          keputusanAnzieti = keputusanAnzieti + skor;
        }else if(skor == 1){
          keputusanAnzieti = keputusanAnzieti + skor;
        }else if(skor == 2){
          keputusanAnzieti = keputusanAnzieti + skor;
        }else if(skor == 3){
          keputusanAnzieti = keputusanAnzieti + skor;
        }
      }

      if(soalanKemurungan.Contains(nomborSoalan)){
        if(skor == 0){
          keputusanKemurungan = keputusanKemurungan + skor;
        }else if(skor == 1){
          keputusanKemurungan = keputusanKemurungan + skor;
        }else if(skor == 2){
          keputusanKemurungan = keputusanKemurungan + skor;
        }else if(skor == 3){
          keputusanKemurungan = keputusanKemurungan + skor;
        }
      }
    } else{

      

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor"
                                                    
      if(keputusanKemurungan  <= 5){
          tahapKemurungan = "Normal";
      }else if(keputusanKemurungan == 6 || keputusanKemurungan == 7){
          tahapKemurungan = "Ringan";
      }else if(keputusanKemurungan !< 8 && keputusanKemurungan <= 10){
          tahapKemurungan = "Sederhana";
      }else if(keputusanKemurungan !< 11 && keputusanKemurungan <= 14){
          tahapKemurungan = "Teruk";
      }else if(keputusanKemurungan >= 15){
        tahapKemurungan = "Sangat Teruk";
      }


      

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor"
                                                 
      if(keputusanAnzieti  <= 4){
          tahapAnzieti = "Normal";
      }else if(keputusanAnzieti == 5 || keputusanAnzieti == 6){
          tahapAnzieti = "Ringan";
      }else if(keputusanAnzieti == 7 || keputusanAnzieti == 8){
          tahapAnzieti = "Sederhana";
      }else if(keputusanAnzieti == 9 || keputusanAnzieti == 10){
          tahapAnzieti = "Teruk";
      }else if(keputusanAnzieti >= 11){
        tahapAnzieti = "Sangat Teruk";
      }

      

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "/Users/user/Desktop/Coding Project/dassproject/Pages/Question.razor"
                                                
      if(keputusanStress  <= 7){
          tahapStress = "Normal";
      }else if(keputusanStress == 8 || keputusanStress == 9){
          tahapStress = "Ringan";
      }else if(keputusanStress !< 10 && keputusanStress <= 13){
          tahapStress = "Sederhana";
      }else if(keputusanStress !< 14 && keputusanStress <= 17){
          tahapStress = "Teruk";
      }else if(keputusanStress >= 18){
        tahapStress = "Sangat Teruk";
      }

      NavigationManager.NavigateTo($"result/" + tahapAnzieti + "/" + tahapStress + "/" + tahapKemurungan);

    }

    nomborSoalan = updateNomborSoalan();
    soalan = dapatkanSoalan(nomborSoalan);
    currentQuestion = $"{soalan}";
  }

  private int updateNomborSoalan()
  {
    i++;
    return i;
  }

  private string dapatkanSoalan(int nomborSoalan)
  {
    switch (nomborSoalan)
    {
      case 2:
        string soalan_2 = "Saya sedar mulut saya terasa kering";
        return soalan_2;

      case 3:
        string soalan_3 = "Saya tidak dapat mengalami perasaan positif sama sekali";
        return soalan_3;

      case 4:
        string soalan_4 = "Saya mengalami kesukaran bernafas (contohnya pernafasan yang laju, tercungap-cungap walaupun tidak melakukan senaman fizikal)";
        return soalan_4;

      case 5:
        string soalan_5 = "Saya sukar mendapatkan semangat bagi melakukan sesuatu perkara";
        return soalan_5;

      case 6:
        string soalan_6 = "Saya cenderung untuk bertindak keterlaluan dalam sesuatu keadaan";
        return soalan_6;

      case 7:
        string soalan_7 = "Saya rasa menggeletar (contohnya pada tangan)";
        return soalan_7;

      case 8:
        string soalan_8 = "Saya rasa saya menggunakan banyak tenaga dalam keadaan cemas";
        return soalan_8;

      case 9:
        string soalan_9 = "Saya bimbang keadaan dimana saya mungkin menjadi panik dan melakukan perkara yang membodohkan diri saya";
        return soalan_9;

      case 10:
        string soalan_10 = "Saya rasa saya tidak menpunyai apa apa untuk diharapkan";
        return soalan_10;

      case 11:
        string soalan_11= "Saya dapati diri saya semakin gelisah";
        return soalan_11;

      case 12:
        string soalan_12 = "Saya rasa sukar untuk relaks";
        return soalan_12;

      case 13:
        string soalan_13 = "Saya rasa sedih dan murung";
        return soalan_13;

      case 14:
        string soalan_14 = "Saya tidak dapat menahan sabar dengan perkara yang menghalang saya meneruskan apa yang saya lakukan";
        return soalan_14;

      case 15:
        string soalan_15= "Saya rasa hampir hampir menjadi panik/cemas";
        return soalan_15;

      case 16:
        string soalan_16 = "Saya tidak bersemangat dengan apa jua yang saya lakukan";
        return soalan_16;

      case 17:
        string soalan_17 = "Saya rasa tidak begitu berharga sebagai seorang individu";
        return soalan_17;

      case 18:
        string soalan_18 = "Saya rasa mudah tersentuh";
        return soalan_18;

      case 19:
        string soalan_19 = "Saya sedar tindakbalas jantung saya walupun tidak melakujan aktiviti fizikal (contohnya kadar denyutan jantung bertambah, atau denyutan jantung berkurangan)";
        return soalan_19;

      case 20:
        string soalan_20 = "Saya merasa takut tanpa sebab yang munasabah";
        return soalan_20;

      case 21:
        string soalan_21= "Saya rasa hidup ini tidak bermakna";
        flag_endquestion = true;
        return soalan_21;

      default:
        string soalan_tamat1= "Soalan Tamat";
        return soalan_tamat1;
    }
  }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
