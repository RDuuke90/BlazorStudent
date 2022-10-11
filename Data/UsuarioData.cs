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
        for(var i = 1; i < 5; i++) {
            UsuarioDTO usuario = new UsuarioDTO {
                    Id = i,
                    Nombres = this.Nombres[random.Next(3)],
                    Apellidos = this.Apellidos[random.Next(3)],
                    Edad = random.Next(100)
            };
            ListUsuario.Add(usuario);
        }

        return ListUsuario;
    }
}