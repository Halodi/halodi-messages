using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "IntegerRange" defined in "IntegerRange.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from IntegerRange.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit IntegerRange.idl instead.
*
*/
public class IntegerRangePubSubType : Halodi.CDR.TopicDataType<IntegerRange>
{
   public override string Name => "rcl_interfaces::msg::dds_::IntegerRange_";


   public static int getCdrSerializedSize(rcl_interfaces.msg.IntegerRange data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.IntegerRange data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.IntegerRange data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_11(data.from_value);

      cdr.write_type_11(data.to_value);

      cdr.write_type_12(data.step);

   }

   public static void read(rcl_interfaces.msg.IntegerRange data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.from_value=cdr.read_type_11();
      	
      data.to_value=cdr.read_type_11();
      	
      data.step=cdr.read_type_12();
      	

   }


	public override void Serialize(rcl_interfaces.msg.IntegerRange data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(rcl_interfaces.msg.IntegerRange data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(rcl_interfaces.msg.IntegerRange data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(rcl_interfaces.msg.IntegerRange src, rcl_interfaces.msg.IntegerRange target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(rcl_interfaces.msg.IntegerRange src, rcl_interfaces.msg.IntegerRange target)
    {
    	Copy(src, target);
    }


}


}