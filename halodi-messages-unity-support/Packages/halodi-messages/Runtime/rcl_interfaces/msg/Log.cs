using System.Text;
namespace rcl_interfaces.msg
{


[System.Serializable]
public class Log : Halodi.CDR.DataType<Log>
{

	public Halodi.CDR.TopicDataType<Log> Type => new LogPubSubType();
	
   /**
          * #
          * # Severity level constants
          * #
          * debug level
          */
   public const byte DEBUG = (byte) 10;
   /**
          * general level
          */
   public const byte INFO = (byte) 20;
   /**
          * warning level
          */
   public const byte WARN = (byte) 30;
   /**
          * error level
          */
   public const byte ERROR = (byte) 40;
   /**
          * fatal/critical level
          */
   public const byte FATAL = (byte) 50;
   /**
            * #
            * # Fields
            * #
            */
   public builtin_interfaces.msg.Time stamp;
   public byte level;
   /**
            * the name representing the logger this message came from
            */
   public string name;
   /**
            * message
            */
   public string msg;
   /**
            * file the message came from
            */
   public string file;
   /**
            * function the message came from
            */
   public string function;
   /**
            * line the message came from
            */
   public uint line;


   public void Set(Log other)
   {
      builtin_interfaces.msg.TimePubSubType.Copy(other.stamp, stamp);

      level = other.level;

      name = other.name;

      msg = other.msg;

      file = other.file;

      function = other.function;

      line = other.line;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Log {");
      builder.Append("stamp=");
      builder.Append(this.stamp);      builder.Append(", ");
      builder.Append("level=");
      builder.Append(this.level);      builder.Append(", ");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("msg=");
      builder.Append(this.msg);      builder.Append(", ");
      builder.Append("file=");
      builder.Append(this.file);      builder.Append(", ");
      builder.Append("function=");
      builder.Append(this.function);      builder.Append(", ");
      builder.Append("line=");
      builder.Append(this.line);
      builder.Append("}");
      return builder.ToString();
   }
}


}