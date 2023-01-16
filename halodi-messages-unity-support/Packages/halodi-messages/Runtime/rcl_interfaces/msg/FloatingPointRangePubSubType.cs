using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "FloatingPointRange" defined in "FloatingPointRange.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FloatingPointRange.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FloatingPointRange.idl instead.
*
*/
public class FloatingPointRangePubSubType : Halodi.CDR.TopicDataType<FloatingPointRange>
{
   public override string Name => "rcl_interfaces::msg::dds_::FloatingPointRange_";


   public static int getCdrSerializedSize(rcl_interfaces.msg.FloatingPointRange data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.FloatingPointRange data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.FloatingPointRange data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.from_value);

      cdr.write_type_6(data.to_value);

      cdr.write_type_6(data.step);

   }

   public static void read(rcl_interfaces.msg.FloatingPointRange data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.from_value=cdr.read_type_6();
      	
      data.to_value=cdr.read_type_6();
      	
      data.step=cdr.read_type_6();
      	

   }


	public override void Serialize(rcl_interfaces.msg.FloatingPointRange data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(rcl_interfaces.msg.FloatingPointRange data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(rcl_interfaces.msg.FloatingPointRange data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(rcl_interfaces.msg.FloatingPointRange src, rcl_interfaces.msg.FloatingPointRange target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(rcl_interfaces.msg.FloatingPointRange src, rcl_interfaces.msg.FloatingPointRange target)
    {
    	Copy(src, target);
    }


}


}