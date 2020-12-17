// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/ExtrinsicCalibrationInfo.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/extrinsic_calibration_info__struct.hpp"
#include "rosidl_typesupport_introspection_cpp/field_types.hpp"
#include "rosidl_typesupport_introspection_cpp/identifier.hpp"
#include "rosidl_typesupport_introspection_cpp/message_introspection.hpp"
#include "rosidl_typesupport_introspection_cpp/message_type_support_decl.hpp"
#include "rosidl_typesupport_introspection_cpp/visibility_control.h"

namespace halodi_msgs
{

namespace msg
{

namespace rosidl_typesupport_introspection_cpp
{

void ExtrinsicCalibrationInfo_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::ExtrinsicCalibrationInfo(_init);
}

void ExtrinsicCalibrationInfo_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::ExtrinsicCalibrationInfo *>(message_memory);
  typed_message->~ExtrinsicCalibrationInfo();
}

size_t size_function__ExtrinsicCalibrationInfo__sensor_transforms(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<geometry_msgs::msg::TransformStamped> *>(untyped_member);
  return member->size();
}

const void * get_const_function__ExtrinsicCalibrationInfo__sensor_transforms(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<geometry_msgs::msg::TransformStamped> *>(untyped_member);
  return &member[index];
}

void * get_function__ExtrinsicCalibrationInfo__sensor_transforms(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<geometry_msgs::msg::TransformStamped> *>(untyped_member);
  return &member[index];
}

void resize_function__ExtrinsicCalibrationInfo__sensor_transforms(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<geometry_msgs::msg::TransformStamped> *>(untyped_member);
  member->resize(size);
}

size_t size_function__ExtrinsicCalibrationInfo__link_infos(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<geometry_msgs::msg::TransformStamped> *>(untyped_member);
  return member->size();
}

const void * get_const_function__ExtrinsicCalibrationInfo__link_infos(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<geometry_msgs::msg::TransformStamped> *>(untyped_member);
  return &member[index];
}

void * get_function__ExtrinsicCalibrationInfo__link_infos(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<geometry_msgs::msg::TransformStamped> *>(untyped_member);
  return &member[index];
}

void resize_function__ExtrinsicCalibrationInfo__link_infos(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<geometry_msgs::msg::TransformStamped> *>(untyped_member);
  member->resize(size);
}

size_t size_function__ExtrinsicCalibrationInfo__joint_infos(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::RobotJointCalibrationInfo> *>(untyped_member);
  return member->size();
}

const void * get_const_function__ExtrinsicCalibrationInfo__joint_infos(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::RobotJointCalibrationInfo> *>(untyped_member);
  return &member[index];
}

void * get_function__ExtrinsicCalibrationInfo__joint_infos(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::RobotJointCalibrationInfo> *>(untyped_member);
  return &member[index];
}

void resize_function__ExtrinsicCalibrationInfo__joint_infos(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::RobotJointCalibrationInfo> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember ExtrinsicCalibrationInfo_message_member_array[3] = {
  {
    "sensor_transforms",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::TransformStamped>(),  // members of sub message
    true,  // is array
    255,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::ExtrinsicCalibrationInfo, sensor_transforms),  // bytes offset in struct
    nullptr,  // default value
    size_function__ExtrinsicCalibrationInfo__sensor_transforms,  // size() function pointer
    get_const_function__ExtrinsicCalibrationInfo__sensor_transforms,  // get_const(index) function pointer
    get_function__ExtrinsicCalibrationInfo__sensor_transforms,  // get(index) function pointer
    resize_function__ExtrinsicCalibrationInfo__sensor_transforms  // resize(index) function pointer
  },
  {
    "link_infos",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::TransformStamped>(),  // members of sub message
    true,  // is array
    255,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::ExtrinsicCalibrationInfo, link_infos),  // bytes offset in struct
    nullptr,  // default value
    size_function__ExtrinsicCalibrationInfo__link_infos,  // size() function pointer
    get_const_function__ExtrinsicCalibrationInfo__link_infos,  // get_const(index) function pointer
    get_function__ExtrinsicCalibrationInfo__link_infos,  // get(index) function pointer
    resize_function__ExtrinsicCalibrationInfo__link_infos  // resize(index) function pointer
  },
  {
    "joint_infos",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::RobotJointCalibrationInfo>(),  // members of sub message
    true,  // is array
    255,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::ExtrinsicCalibrationInfo, joint_infos),  // bytes offset in struct
    nullptr,  // default value
    size_function__ExtrinsicCalibrationInfo__joint_infos,  // size() function pointer
    get_const_function__ExtrinsicCalibrationInfo__joint_infos,  // get_const(index) function pointer
    get_function__ExtrinsicCalibrationInfo__joint_infos,  // get(index) function pointer
    resize_function__ExtrinsicCalibrationInfo__joint_infos  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers ExtrinsicCalibrationInfo_message_members = {
  "halodi_msgs::msg",  // message namespace
  "ExtrinsicCalibrationInfo",  // message name
  3,  // number of fields
  sizeof(halodi_msgs::msg::ExtrinsicCalibrationInfo),
  ExtrinsicCalibrationInfo_message_member_array,  // message members
  ExtrinsicCalibrationInfo_init_function,  // function to initialize message memory (memory has to be allocated)
  ExtrinsicCalibrationInfo_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t ExtrinsicCalibrationInfo_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &ExtrinsicCalibrationInfo_message_members,
  get_message_typesupport_handle_function,
};

}  // namespace rosidl_typesupport_introspection_cpp

}  // namespace msg

}  // namespace halodi_msgs


namespace rosidl_typesupport_introspection_cpp
{

template<>
ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
get_message_type_support_handle<halodi_msgs::msg::ExtrinsicCalibrationInfo>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::ExtrinsicCalibrationInfo_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, ExtrinsicCalibrationInfo)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::ExtrinsicCalibrationInfo_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
