using System.IO;
namespace builtin_interfaces.msg
{

/**
* 
* Topic data type of the struct "Time" defined in "Time.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Time.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Time.idl instead.
*
*/
public class TimePubSubType : Halodi.CDR.TopicDataType<Time>
{
   public override string Name => "builtin_interfaces::msg::dds_::Time_";


   public static int getCdrSerializedSize(builtin_interfaces.msg.Time data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(builtin_interfaces.msg.Time data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(builtin_interfaces.msg.Time data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.sec);

      cdr.write_type_4(data.nanosec);

   }

   public static void read(builtin_interfaces.msg.Time data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.sec=cdr.read_type_2();
      	
      data.nanosec=cdr.read_type_4();
      	

   }


	public override void Serialize(builtin_interfaces.msg.Time data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(builtin_interfaces.msg.Time data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(builtin_interfaces.msg.Time data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(builtin_interfaces.msg.Time src, builtin_interfaces.msg.Time target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(builtin_interfaces.msg.Time src, builtin_interfaces.msg.Time target)
    {
    	Copy(src, target);
    }


}


}