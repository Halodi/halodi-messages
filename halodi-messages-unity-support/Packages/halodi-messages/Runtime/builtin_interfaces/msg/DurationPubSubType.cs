using System.IO;
namespace builtin_interfaces.msg
{

/**
* 
* Topic data type of the struct "Duration" defined in "Duration.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Duration.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Duration.idl instead.
*
*/
public class DurationPubSubType : Halodi.CDR.TopicDataType<Duration>
{
   public override string Name => "builtin_interfaces::msg::dds_::Duration_";


   public static int getCdrSerializedSize(builtin_interfaces.msg.Duration data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(builtin_interfaces.msg.Duration data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(builtin_interfaces.msg.Duration data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.sec);

      cdr.write_type_4(data.nanosec);

   }

   public static void read(builtin_interfaces.msg.Duration data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.sec=cdr.read_type_2();
      	
      data.nanosec=cdr.read_type_4();
      	

   }


	public override void Serialize(builtin_interfaces.msg.Duration data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(builtin_interfaces.msg.Duration data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(builtin_interfaces.msg.Duration data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(builtin_interfaces.msg.Duration src, builtin_interfaces.msg.Duration target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(builtin_interfaces.msg.Duration src, builtin_interfaces.msg.Duration target)
    {
    	Copy(src, target);
    }


}


}