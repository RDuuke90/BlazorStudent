namespace UserCrud.Data;


public class UsuarioData
{
    private List<string> Nombres = new List<string>(){
        "Juan", "Pedro", "Andres"
    };

    private List<string> Apellidos = new List<string>(){
        "Duque", "Gonzales", "Alvares"
    };
    public List<UsuarioDTO> GetUsuarios ()
    {
        List<UsuarioDTO> ListUsuario = new ();
        Random random = new Random();
        for(var i = 0; i < 3; i++) {
            UsuarioDTO usuario = new UsuarioDTO {
                    Id = i+1,
                    Nombres = this.Nombres[i],
                    Apellidos = this.Apellidos[i],
                    Edad = random.Next(100)
            };
            ListUsuario.Add(usuario);
        }

        return ListUsuario;
    }
}