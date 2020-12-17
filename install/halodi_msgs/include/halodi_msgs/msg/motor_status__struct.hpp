// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/MotorStatus.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__MOTOR_STATUS__STRUCT_HPP_
#define HALODI_MSGS__MSG__MOTOR_STATUS__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'joints'
#include "halodi_msgs/msg/joint_name__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__MotorStatus __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__MotorStatus __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct MotorStatus_
{
  using Type = MotorStatus_<ContainerAllocator>;

  explicit MotorStatus_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->status_level = 0;
      this->motor_id = 0;
      this->sto_enabled = false;
      this->over_temperature = false;
      this->motor_serial_number = 0ul;
      this->driver_serial_number = 0ul;
      this->motor_initialized = false;
      this->motor_temperature = 0.0;
      this->driver_temperature = 0.0;
      this->motor_error = 0;
    }
  }

  explicit MotorStatus_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->status_level = 0;
      this->motor_id = 0;
      this->sto_enabled = false;
      this->over_temperature = false;
      this->motor_serial_number = 0ul;
      this->driver_serial_number = 0ul;
      this->motor_initialized = false;
      this->motor_temperature = 0.0;
      this->driver_temperature = 0.0;
      this->motor_error = 0;
    }
  }

  // field types and members
  using _status_level_type =
    unsigned char;
  _status_level_type status_level;
  using _joints_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointName_<ContainerAllocator>, 2, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointName_<ContainerAllocator>>::other>;
  _joints_type joints;
  using _motor_id_type =
    unsigned char;
  _motor_id_type motor_id;
  using _sto_enabled_type =
    bool;
  _sto_enabled_type sto_enabled;
  using _over_temperature_type =
    bool;
  _over_temperature_type over_temperature;
  using _motor_serial_number_type =
    uint32_t;
  _motor_serial_number_type motor_serial_number;
  using _driver_serial_number_type =
    uint32_t;
  _driver_serial_number_type driver_serial_number;
  using _motor_initialized_type =
    bool;
  _motor_initialized_type motor_initialized;
  using _motor_temperature_type =
    double;
  _motor_temperature_type motor_temperature;
  using _driver_temperature_type =
    double;
  _driver_temperature_type driver_temperature;
  using _motor_error_type =
    unsigned char;
  _motor_error_type motor_error;

  // setters for named parameter idiom
  Type & set__status_level(
    const unsigned char & _arg)
  {
    this->status_level = _arg;
    return *this;
  }
  Type & set__joints(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointName_<ContainerAllocator>, 2, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointName_<ContainerAllocator>>::other> & _arg)
  {
    this->joints = _arg;
    return *this;
  }
  Type & set__motor_id(
    const unsigned char & _arg)
  {
    this->motor_id = _arg;
    return *this;
  }
  Type & set__sto_enabled(
    const bool & _arg)
  {
    this->sto_enabled = _arg;
    return *this;
  }
  Type & set__over_temperature(
    const bool & _arg)
  {
    this->over_temperature = _arg;
    return *this;
  }
  Type & set__motor_serial_number(
    const uint32_t & _arg)
  {
    this->motor_serial_number = _arg;
    return *this;
  }
  Type & set__driver_serial_number(
    const uint32_t & _arg)
  {
    this->driver_serial_number = _arg;
    return *this;
  }
  Type & set__motor_initialized(
    const bool & _arg)
  {
    this->motor_initialized = _arg;
    return *this;
  }
  Type & set__motor_temperature(
    const double & _arg)
  {
    this->motor_temperature = _arg;
    return *this;
  }
  Type & set__driver_temperature(
    const double & _arg)
  {
    this->driver_temperature = _arg;
    return *this;
  }
  Type & set__motor_error(
    const unsigned char & _arg)
  {
    this->motor_error = _arg;
    return *this;
  }

  // constant declarations
  // guard against 'NO_ERROR' being predefined by MSVC by temporarily undefining it
#if defined(_WIN32)
#  if defined(NO_ERROR)
#    pragma push_macro("NO_ERROR")
#    undef NO_ERROR
#  endif
#endif
  static constexpr unsigned char NO_ERROR =
    0;
#if defined(_WIN32)
#  pragma warning(suppress : 4602)
#  pragma pop_macro("NO_ERROR")
#endif
  static constexpr unsigned char FAULTED =
    1;
  static constexpr unsigned char MISSED_DEADLINE =
    2;
  static constexpr unsigned char AUX_ENCODER_WARNING =
    3;
  static constexpr unsigned char AUX_ENCODER_ERROR =
    4;
  static constexpr unsigned char MOTOR_ENCODER_WARNING =
    5;
  static constexpr unsigned char MOTOR_ENCODER_ERROR =
    6;
  static constexpr unsigned char OVER_TEMPERATURE =
    7;
  static constexpr unsigned char OVER_VOLTAGE =
    8;
  static constexpr unsigned char UNDER_VOLTAGE =
    9;
  static constexpr unsigned char ETHERCAT_FAULT =
    10;
  static constexpr unsigned char INVALID_STATE_TRANSITION =
    11;

  // pointer types
  using RawPtr =
    halodi_msgs::msg::MotorStatus_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::MotorStatus_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::MotorStatus_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::MotorStatus_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::MotorStatus_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::MotorStatus_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::MotorStatus_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::MotorStatus_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::MotorStatus_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::MotorStatus_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__MotorStatus
    std::shared_ptr<halodi_msgs::msg::MotorStatus_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__MotorStatus
    std::shared_ptr<halodi_msgs::msg::MotorStatus_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const MotorStatus_ & other) const
  {
    if (this->status_level != other.status_level) {
      return false;
    }
    if (this->joints != other.joints) {
      return false;
    }
    if (this->motor_id != other.motor_id) {
      return false;
    }
    if (this->sto_enabled != other.sto_enabled) {
      return false;
    }
    if (this->over_temperature != other.over_temperature) {
      return false;
    }
    if (this->motor_serial_number != other.motor_serial_number) {
      return false;
    }
    if (this->driver_serial_number != other.driver_serial_number) {
      return false;
    }
    if (this->motor_initialized != other.motor_initialized) {
      return false;
    }
    if (this->motor_temperature != other.motor_temperature) {
      return false;
    }
    if (this->driver_temperature != other.driver_temperature) {
      return false;
    }
    if (this->motor_error != other.motor_error) {
      return false;
    }
    return true;
  }
  bool operator!=(const MotorStatus_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct MotorStatus_

// alias to use template instance with default allocator
using MotorStatus =
  halodi_msgs::msg::MotorStatus_<std::allocator<void>>;

// constant definitions
// guard against 'NO_ERROR' being predefined by MSVC by temporarily undefining it
#if defined(_WIN32)
#  if defined(NO_ERROR)
#    pragma push_macro("NO_ERROR")
#    undef NO_ERROR
#  endif
#endif
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::NO_ERROR;
#if defined(_WIN32)
#  pragma warning(suppress : 4602)
#  pragma pop_macro("NO_ERROR")
#endif
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::FAULTED;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::MISSED_DEADLINE;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::AUX_ENCODER_WARNING;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::AUX_ENCODER_ERROR;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::MOTOR_ENCODER_WARNING;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::MOTOR_ENCODER_ERROR;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::OVER_TEMPERATURE;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::OVER_VOLTAGE;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::UNDER_VOLTAGE;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::ETHERCAT_FAULT;
template<typename ContainerAllocator>
constexpr unsigned char MotorStatus_<ContainerAllocator>::INVALID_STATE_TRANSITION;

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__MOTOR_STATUS__STRUCT_HPP_
