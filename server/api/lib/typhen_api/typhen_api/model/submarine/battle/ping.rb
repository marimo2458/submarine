# This file was generated by typhen-api

module TyphenApi::Model::Submarine::Battle
  class Ping
    include Virtus.model(:strict => true)

    attribute :message, String, :required => true
  end
end