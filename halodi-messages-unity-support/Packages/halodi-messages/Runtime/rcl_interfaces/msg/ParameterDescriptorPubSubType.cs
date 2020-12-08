using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "ParameterDescriptor" defined in "ParameterDescriptor.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ParameterDescriptor.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ParameterDescriptor.idl instead.
*
*/
public class ParameterDescriptorPubSubType : Halodi.CDR.TopicDataType<ParameterDescriptor>
{
   public override string Name => "rcl_interfaces::msg::dds_::ParameterDescriptor_";


   
   public override void serialize(rcl_interfaces.msg.ParameterDescriptor data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, rcl_interfaces.msg.ParameterDescriptor data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.ParameterDescriptor data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.ParameterDescriptor data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.description.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.additional_constraints.Length + 1;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.floating_point_range.Count; ++i0)
      {
          current_alignment += rcl_interfaces.msg.FloatingPointRangePubSubType.getCdrSerializedSize(data.floating_point_range[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.integer_range.Count; ++i0)
      {
          current_alignment += rcl_interfaces.msg.IntegerRangePubSubType.getCdrSerializedSize(data.integer_range[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.ParameterDescriptor data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.name);

      cdr.write_type_9(data.type);

      cdr.write_type_d(data.description);

      cdr.write_type_d(data.additional_constraints);

      cdr.write_type_7(data.read_only);

      	if(data.floating_point_range == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int floating_point_range_length = data.floating_point_range.Count;
            cdr.write_type_2(floating_point_range_length);
            for (int i0 = 0; i0 < floating_point_range_length; i0++)
            {
      			rcl_interfaces.msg.FloatingPointRangePubSubType.write(data.floating_point_range[i0], cdr);	      }
        }
      	if(data.integer_range == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int integer_range_length = data.integer_range.Count;
            cdr.write_type_2(integer_range_length);
            for (int i0 = 0; i0 < integer_range_length; i0++)
            {
      			rcl_interfaces.msg.IntegerRangePubSubType.write(data.integer_range[i0], cdr);	      }
        }
   }

   public static void read(rcl_interfaces.msg.ParameterDescriptor data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.name = cdr.read_type_d();	
      data.type=cdr.read_type_9();
      	
      data.description = cdr.read_type_d();	
      data.additional_constraints = cdr.read_type_d();	
      data.read_only=cdr.read_type_7();
      	

      int floating_point_range_length = cdr.read_type_2();
      data.floating_point_range = new System.Collections.Generic.List<rcl_interfaces.msg.FloatingPointRange>(floating_point_range_length);
      for(int i = 0; i < floating_point_range_length; i++)
      {
      	rcl_interfaces.msg.FloatingPointRange new_floating_point_range = rcl_interfaces.msg.FloatingPointRangePubSubType.Create(); 
      	rcl_interfaces.msg.FloatingPointRangePubSubType.read(new_floating_point_range, cdr);
      	data.floating_point_range.Add(new_floating_point_range);	
      	
      }

      	

      int integer_range_length = cdr.read_type_2();
      data.integer_range = new System.Collections.Generic.List<rcl_interfaces.msg.IntegerRange>(integer_range_length);
      for(int i = 0; i < integer_range_length; i++)
      {
      	rcl_interfaces.msg.IntegerRange new_integer_range = rcl_interfaces.msg.IntegerRangePubSubType.Create(); 
      	rcl_interfaces.msg.IntegerRangePubSubType.read(new_integer_range, cdr);
      	data.integer_range.Add(new_integer_range);	
      	
      }

      	

   }


    public static void Copy(rcl_interfaces.msg.ParameterDescriptor src, rcl_interfaces.msg.ParameterDescriptor target)
    {
        target.Set(src);
    }


}


}