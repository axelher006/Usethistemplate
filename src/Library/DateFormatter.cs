namespace Ucu.Poo.TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{
    private const int VALID_DATE_LENGTH = 10;
    private const int POS_FIRST_SEPARATOR = 2;
    private const int POS_SECOND_SEPARATOR = 5;
    private const char INPUT_DATE_SEPARATOR = '/';

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd".
    ///
    /// Cambio #1. En caso de que la fecha no tenga el formato correcto, se retorna una cadena vacía.
    ///
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        // #1
        if (!LengthIsValid(date))
        {
             return string.Empty;
        }

        // #2
        if (!SeparatorsAreValid(date))
        {
            return string.Empty;
        }

        // #3
         if (!ComponentsAreValid(date))
         {
             return string.Empty;
         }

        return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
    }

    // Retorna true si la fecha recibida tiene la cantidad de caracteres correcta —10— y false en caso contrario.
    private static bool LengthIsValid(string date)
    {
        return date.Length == VALID_DATE_LENGTH;
    }

    // Retorna true si la fecha recibida tiene los separadores en la posición correcta y false en caso contrario.
    private static bool SeparatorsAreValid(string date)
    {
        return date[POS_FIRST_SEPARATOR] == INPUT_DATE_SEPARATOR && date[POS_SECOND_SEPARATOR] == INPUT_DATE_SEPARATOR;
    }

    // Retorna true si el día de la fecha recibida es correcto y false en caso contrario.
    private static bool ComponentsAreValid(string date)
    {
        bool result = false;
        string[] components = date.Split(INPUT_DATE_SEPARATOR);

        if (components.Length == 3)
        {
            int day;
            int month;
            int year;

            result =
                int.TryParse(components[0], out day) &&
                int.TryParse(components[1], out month) &&
                int.TryParse(components[2], out year) &&
                day >= 1 && day <= 31 &&
                month >= 1 && month <= 12;
        }

        return result;
    }
}
